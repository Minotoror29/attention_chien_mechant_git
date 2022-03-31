using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerController controller;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var controllers = FindObjectsOfType<PlayerController>();
        int index = playerInput.playerIndex;
        controller = controllers.FirstOrDefault(m => m.playerindex == index);
    }

    public void Up()
    {
        if (controller != null)
            if (!controller.stunned)
                controller.wantedDirection = Vector2.up;
    }

    public void Down()
    {
        if (controller != null)
            if (!controller.stunned)
                controller.wantedDirection = Vector2.down;
    }
    public void Right()
    {
        if (controller != null)
            if (!controller.stunned)
                controller.wantedDirection = Vector2.right;
    }

    public void Left()
    {
        if (controller != null)
            if (!controller.stunned)
                controller.wantedDirection = Vector2.left;
    }
}
