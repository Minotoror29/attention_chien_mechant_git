using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    private GameManager gm;

    [SerializeField] private Text timerText;
    public bool game = false;

    [SerializeField] private float startTime = 20;
    private float actualTime;

    private void Start()
    {
        gm = GameManager.Instance;

        actualTime = startTime;
    }

    private void Update()
    {
        if (!game)
            return;

        if (actualTime > 0)
        {
            actualTime -= Time.deltaTime;
            timerText.text = ((int)actualTime).ToString();
        } else
        {
            game = false;
            if (gm.actualMailBoxes <= 0)
            {
                gm.GameOver(PlayerType.Mailman);
            }
            else
            {
                gm.GameOver(PlayerType.Draw);
            }
        }
    }
}
