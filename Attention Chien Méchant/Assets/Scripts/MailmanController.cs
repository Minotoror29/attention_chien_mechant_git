using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailmanController : PlayerController
{
    private bool onBike = false;
    [SerializeField] private float bikeSpeedBoost;

    public void Bike(GameObject bike)
    {
        if (onBike)
        {
            return;
        }

        onBike = true;
        actualSpeed += bikeSpeedBoost;
        wantedDirection = Vector2.zero;
        Destroy(bike);
    }

    public void BikeCollision(string tag)
    {
        if (!onBike)
        {
            return;
        }

        FallOffBike();
    }

    private void FallOffBike()
    {
        onBike = false;
        actualSpeed = startSpeed;
        Stun();
    }

    public void CrowdCollision()
    {
        if (!onBike)
        {
            return;
        }

        direction = previousDirection;
        wantedDirection = Vector2.zero;
        FallOffBike();
    }

    public void DogCollision(string tag)
    {
        if (tag == "Dog")
        {
            gm.GameOver(PlayerType.Dog);
        }
    }

    private void OnEnable()
    {
        OnCollision += BikeCollision;
        OnCollision += DogCollision;
        OnCrowd += CrowdCollision;
    }

    private void OnDisable()
    {
        OnCollision -= BikeCollision;
        OnCollision -= DogCollision;
        OnCrowd -= CrowdCollision;
    }
}
