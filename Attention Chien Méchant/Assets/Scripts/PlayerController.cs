using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public enum PlayerType { Mailman, Dog }

[RequireComponent(typeof (Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [NonSerialized] public GameManager gm;

    public int playerindex;
    public PlayerType playerType;

    [NonSerialized] public Vector2 wantedDirection;
    [NonSerialized] public Vector2 direction;
    [NonSerialized] public Vector2 previousDirection;
    public float startSpeed;
    public float actualSpeed;

    [SerializeField] private float tiling;

    public bool stunned = false;
    [SerializeField] private float stunTime;
    private float stunTimer = 0;

    public bool inCrowd = false;
    private int crowds = 0;

    public event Action<string> OnCollision;
    public event Action OnCrowd;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();

        actualSpeed = startSpeed;
        direction = transform.position;
    }

    private void Update()
    {
        ChangeDirection();
        StunTimer();
    }

    private void ChangeDirection()
    {
        if (transform.position == (Vector3)direction)
        {
            previousDirection = direction;
            direction += wantedDirection * tiling;
        }
    }

    public void Up()
    {
        if (!stunned && gm.canPlay)
            wantedDirection = Vector2.up;
    }

    public void Down()
    {
        if (!stunned && gm.canPlay)
            wantedDirection = Vector2.down;
    }
    public void Right()
    {
        if (!stunned && gm.canPlay)
            wantedDirection = Vector2.right;
    }

    public void Left()
    {
        if (!stunned && gm.canPlay)
            wantedDirection = Vector2.left;
    }

    private void FixedUpdate()
    {
        //transform.position = Vector2.MoveTowards(transform.position, direction, actualSpeed * Time.deltaTime);
        transform.position = Vector2.Lerp(transform.position, direction, actualSpeed * Time.deltaTime);
    }

    public void Stun()
    {
        stunned = true;
        stunTimer = stunTime;
    }

    private void StunTimer()
    {
        if (stunTimer <= 0)
        {
            stunned = false;
            return;
        }

        stunTimer -= Time.deltaTime;
    }

    public void Crowd(bool inCrowd, float speedInCrowd)
    {
        if (inCrowd)
        {
            if (crowds == 0)
            {
                actualSpeed /= speedInCrowd;
            }
            crowds += 1;
            OnCrowd?.Invoke();
        } else
        {
            crowds -= 1;
            if (crowds == 0)
            {
                actualSpeed = startSpeed;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        direction = previousDirection;
        wantedDirection = Vector2.zero;

        OnCollision?.Invoke(collision.gameObject.tag);
    }
}
