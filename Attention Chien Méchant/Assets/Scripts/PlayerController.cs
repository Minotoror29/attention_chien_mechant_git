using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

[RequireComponent(typeof (Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public int playerindex;

    [NonSerialized] public Vector2 wantedDirection;
    [NonSerialized] public Vector2 direction;
    [NonSerialized] public Vector2 previousDirection;
    public float startSpeed;
    public float actualSpeed;

    [SerializeField] private float tiling;

    [NonSerialized] public PlayerControls controls;
    /*public KeyCode up;
    public KeyCode down;
    public KeyCode right;
    public KeyCode left;*/

    public bool stunned = false;
    [SerializeField] private float stunTime;
    private float stunTimer = 0;

    public bool inCrowd = false;

    public event Action OnCollision;
    public event Action OnCrowd;

    private void Awake()
    {
        controls = new PlayerControls();

        /*controls.Gameplay.Up.performed += ctx => Up();
        controls.Gameplay.Down.performed += ctx => Down();
        controls.Gameplay.Right.performed += ctx => Right();
        controls.Gameplay.Left.performed += ctx => Left();*/
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

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
        /*if (!stunned)
        {
            if (Input.GetKeyDown(up))
            {
                Up();
            }
            else if (Input.GetKeyDown(down))
            {
                Down();
            }
            else if (Input.GetKeyDown(right))
            {
                Right();
            }
            else if (Input.GetKeyDown(left))
            {
                Left();
            }
        }*/

        if (transform.position == (Vector3)direction)
        {
            previousDirection = direction;
            direction += wantedDirection * tiling;
        }
    }

    public void Up()
    {
        if (!stunned)
            wantedDirection = Vector2.up;
    }

    public void Down()
    {
        if (!stunned)
            wantedDirection = Vector2.down;
    }
    public void Right()
    {
        if (!stunned)
            wantedDirection = Vector2.right;
    }

    public void Left()
    {
        if (!stunned)
            wantedDirection = Vector2.left;
    }


    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, direction, actualSpeed * Time.deltaTime);
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
            actualSpeed -= speedInCrowd;
        } else
        {
            actualSpeed = startSpeed;
        }

        OnCrowd?.Invoke();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        direction = previousDirection;
        wantedDirection = Vector2.zero;

        OnCollision?.Invoke();
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }
}
