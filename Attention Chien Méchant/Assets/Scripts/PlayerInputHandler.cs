using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerController controller;

    private PlayerController[] controllers;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SetPlayer()
    {
        controllers = FindObjectsOfType<PlayerController>();
        int index = playerInput.playerIndex;
        controller = controllers.FirstOrDefault(m => m.playerindex == index);
    }

    // Multiple Controllers
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

    public void Bark()
    {
        if (controller != null)
        {
            if (controller.playerType == PlayerType.Dog)
            {
                controller.GetComponent<DogBark>().Bark();
            }
        }
    }

    // Keyboard

    public void MailmanUp()
    {
        controllers[1].Up();
    }
    public void MailmanDown()
    {
        controllers[1].Down();
    }

    public void MailmanLeft()
    {
        controllers[1].Left();
    }

    public void MailmanRight()
    {
        controllers[1].Right();
    }

    public void DogUp()
    {
        controllers[0].Up();
    }

    public void DogDown()
    {
        controllers[0].Down();
    }

    public void DogLeft()
    {
        controllers[0].Left();
    }

    public void DogRight()
    {
        controllers[0].Right();
    }

    public void DogBark()
    {
        controllers[0].GetComponent<DogBark>().Bark();
    }
}
