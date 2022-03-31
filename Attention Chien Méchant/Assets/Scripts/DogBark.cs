using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogBark : MonoBehaviour
{
    public KeyCode barkKey;

    [SerializeField] private GameObject barkObject;

    private float t = 0;

    private void Update()
    {
        /*if (Input.GetKeyDown(barkKey))
        {
            Bark();
        }*/

        if (barkObject.activeSelf)
        {
            if (t > 0)
            {
                t -= Time.deltaTime;
            } else
            {
                barkObject.SetActive(false);
            }
        }
    }

    private void Bark()
    {
        if (barkObject.activeSelf)
        {
            return;
        }

        barkObject.SetActive(true);

        t = 1;
    }
}
