using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager m_instance;
    public static GameManager Instance => m_instance;

    public bool canPlay = false;

    [SerializeField] private GameObject mailman;
    [SerializeField] private GameObject dog;

    [SerializeField] private int mailBoxesToWin;
    private int actualMailBoxes;

    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private Text gameOverText;

    [SerializeField] private GameTimer gameTimer;

    private void Awake()
    {
        if (m_instance == null)
        {
            m_instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        actualMailBoxes = mailBoxesToWin;

        SetPlayers();
    }

    private void Update()
    {
        // /!\ Test ! A retirer ! /!\
        if (Input.GetKeyDown(KeyCode.P))
        {
            SetPlayers();
        }
    }

    public void SetPlayers()
    {
        var playerInputs = FindObjectsOfType<PlayerInputHandler>();

        foreach (var item in playerInputs)
        {
            item.SetPlayer();
        }
    }

    public void StartGame()
    {
        canPlay = true;
        gameTimer.game = true;
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

        if (type != PlayerType.Draw)
        {
            gameOverText.text = type.ToString().ToUpper() + " WINS";
        } else
        {
            gameOverText.text = "DRAW";
        }
        gameOverCanvas.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
