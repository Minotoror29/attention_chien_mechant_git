using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (DogController))]
public class DogBark : MonoBehaviour
{
    [SerializeField] private GameObject barkObject;

    [SerializeField] private float cooldown;
    private float cooldownTimer;
    private bool canBark = true;

    private float barkTime = 0;

    private void Start()
    {
        cooldownTimer = 0;
    }

    private void Update()
    {
        if (barkObject.activeSelf)
        {
            if (barkTime > 0)
            {
                barkTime -= Time.deltaTime;
            } else
            {
                barkObject.SetActive(false);
            }
        } else
        {
            if (cooldownTimer > 0)
            {
                cooldownTimer -= Time.deltaTime;
            } else
            {
                canBark = true;
                GetComponent<DogController>().inRage = false;
            }
        }
    }

    public void Bark()
    {
        if (barkObject.activeSelf || !canBark)
        {
            return;
        }

        barkObject.SetActive(true);
        canBark = false;
        cooldownTimer = cooldown;

        GetComponent<DogController>().inRage = true;

        barkTime = 1;
    }
}
