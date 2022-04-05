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
            controller.Up();
    }

    public void Down()
    {
        if (controller != null)
            controller.Down();
    }
    public void Right()
    {
        if (controller != null)
            controller.Right();
    }

    public void Left()
    {
        if (controller != null)
            controller.Left();
    }
}
