using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailBox : MonoBehaviour
{
    private GameManager gm;

    private bool active = true;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    public void GatherMailBox()
    {
        gm.GatherMailBox();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<MailmanController>() && active)
        {
            gm.GatherMailBox();
            transform.Find("Sprite").GetComponent<SpriteRenderer>().color = Color.green;
            active = false;
        }
    }
}
