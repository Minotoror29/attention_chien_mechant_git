using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowd : MonoBehaviour
{
    [SerializeField] private float speedInCrowd;

    private bool deactivated = false;
    [SerializeField] private float deactivationTime;
    private float t;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!deactivated)
        {
            if (collision.GetComponent<PlayerController>())
            {
                collision.GetComponent<PlayerController>().Crowd(true, speedInCrowd);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!deactivated)
        {
            if (collision.GetComponent<PlayerController>())
            {
                collision.GetComponent<PlayerController>().Crowd(false, speedInCrowd);
            }
        }
    }

    public void DeactivateCrowd()
    {
        deactivated = true;
        t = deactivationTime;
        transform.Find("Sprite").GetComponent<SpriteRenderer>().color = Color.green;
    }

    private void Update()
    {
        if (deactivated)
        {
            if (t > 0)
            {
                t -= Time.deltaTime;
            } else
            {
                deactivated = false;
                transform.Find("Sprite").GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }
}
