using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof (Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    [NonSerialized] public Vector2 wantedDirection;
    [NonSerialized] public Vector2 direction;
    [NonSerialized] public Vector2 previousDirection;
    public float speed;

    [SerializeField] private float tiling;

    public KeyCode up;
    public KeyCode down;
    public KeyCode right;
    public KeyCode left;

    private bool stunned = false;
    [SerializeField] private float stunTime;
    private float stunTimer = 0;

    public event Action OnCollision;
    public event Action OnCrowd;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        direction = transform.position;
    }

    private void Update()
    {
        ChangeDirection();
        StunTimer();
    }

    private void ChangeDirection()
    {

        if (!stunned)
        {
            if (Input.GetKeyDown(up))
            {
                wantedDirection = Vector2.up;
            }
            else if (Input.GetKeyDown(down))
            {
                wantedDirection = Vector2.down;
            }
            else if (Input.GetKeyDown(right))
            {
                wantedDirection = Vector2.right;
            }
            else if (Input.GetKeyDown(left))
            {
                wantedDirection = Vector2.left;
            }
        }

        if (transform.position == (Vector3)direction)
        {
            previousDirection = direction;
            direction += wantedDirection * tiling;
        }
    }

    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, direction, speed * Time.deltaTime);
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

    public void Crowd(bool inCrowd, float speedReduction)
    {
        if (inCrowd)
        {
            speed -= speedReduction;
        } else
        {
            speed += speedReduction;
        }

        OnCrowd?.Invoke();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        direction = previousDirection;
        wantedDirection = Vector2.zero;

        OnCollision?.Invoke();
    }
}
