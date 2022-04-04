using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowd : MonoBehaviour
{
    [SerializeField] private float speedReduction;

    private bool deactivated = false;
    [SerializeField] private float deactivationTime;
    private float t;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!deactivated)
        {
            if (collision.GetComponent<PlayerController>())
            {
                if (!collision.GetComponent<PlayerController>().inCrowd)
                {
                    collision.GetComponent<PlayerController>().Crowd(true, speedReduction);
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!deactivated)
        {
            if (collision.GetComponent<PlayerController>())
            {
                collision.GetComponent<PlayerController>().Crowd(false, speedReduction);
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
