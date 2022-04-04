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
        Destroy(bike);
    }

    public void BikeCollision()
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

    private void OnEnable()
    {
        controls.Player.Enable();

        OnCollision += BikeCollision;
        OnCrowd += CrowdCollision;
    }

    private void OnDisable()
    {
        controls.Player.Disable();

        OnCollision -= BikeCollision;
        OnCrowd -= CrowdCollision;
    }
}
