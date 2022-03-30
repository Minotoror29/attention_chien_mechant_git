using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarkObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Crowd>())
        {
            collision.GetComponent<Crowd>().DeactivateCrowd();
        }
    }
}
