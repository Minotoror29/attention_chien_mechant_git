using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTimer : MonoBehaviour
{
    private float timer = 3;
    private int timeOnText;
    [SerializeField] private Text timerText;
    [SerializeField] private GameObject timerCanvas;

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        } else
        {
            timerCanvas.SetActive(false);
            GetComponent<GameManager>().canPlay = true;
        }

        if (timer > 2)
        {
            timeOnText = 3;
        } else if (timer > 1)
        {
            timeOnText = 2;
        } else if (timer > 0)
        {
            timeOnText = 1;
        }

        timerText.text = timeOnText.ToString();
    }
}
