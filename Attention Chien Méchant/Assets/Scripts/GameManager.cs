using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool canPlay = false;

    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private Text gameOverText;

    public void GameOver(PlayerType type)
    {
        canPlay = false;

        gameOverText.text = type.ToString().ToUpper() + " WINS";
        gameOverCanvas.SetActive(true);
    }
}
