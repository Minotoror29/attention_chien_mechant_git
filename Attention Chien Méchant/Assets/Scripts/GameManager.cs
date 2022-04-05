using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool canPlay = false;

    [SerializeField] private GameObject mailman;
    [SerializeField] private GameObject dog;

    [SerializeField] private int mailBoxesToWin;
    private int actualMailBoxes;

    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private Text gameOverText;

    private void Start()
    {
        actualMailBoxes = mailBoxesToWin;
    }

    public void GatherMailBox()
    {
        actualMailBoxes -= 1;

        if (actualMailBoxes == 0)
        {
            GameOver(PlayerType.Mailman);
        }
    }

    public void GameOver(PlayerType type)
    {
        canPlay = false;

        mailman.GetComponent<PlayerController>().wantedDirection = Vector2.zero;
        dog.GetComponent<PlayerController>().wantedDirection = Vector2.zero;

        gameOverText.text = type.ToString().ToUpper() + " WINS";
        gameOverCanvas.SetActive(true);
    }
}
