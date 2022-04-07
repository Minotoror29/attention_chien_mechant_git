using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class CharacterSelectionMenu : MonoBehaviour
{
    [SerializeField] private PlayerInputManager playerManager;
    [SerializeField] private PlayerInputHandler playerInputKeyboard;

    private bool canPlay = false;

    private int playerNumber = 0;

    public void AddPlayer(PlayerInput input)
    {
        playerNumber++;

        if (playerNumber == playerManager.maxPlayerCount)
        {
            canPlay = true;
        }
    }

    public void RemovePlayer(PlayerInput input)
    {
        playerNumber--;
    }

    public void Play()
    {
        if (canPlay)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Keyboard()
    {
        Instantiate(playerInputKeyboard);

        canPlay = true;
    }

    public void MultipleControllers()
    {
        playerManager.joinBehavior = PlayerJoinBehavior.JoinPlayersWhenButtonIsPressed;
    }
}
