using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<MailmanController>())
        {
            collision.GetComponent<MailmanController>().Bike(gameObject);
        }
    }
}
