using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : PlayerController
{
    [System.NonSerialized] public bool inRage = false;

    public void StunRage(string type)
    {
        if (inRage)
        {
            Stun();
        }
    }

    private void OnEnable()
    {
        OnCollision += StunRage;
    }

    private void OnDisable()
    {
        OnCollision -= StunRage;
    }
}
