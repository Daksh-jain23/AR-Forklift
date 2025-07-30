using UnityEngine;

public class LeverVehicleController : MonoBehaviour
{
    public Transform lever;           // Lever's transform
    public Rigidbody vehicle;         // Vehicle's Rigidbody
    public float maxSpeed = 10f;      // Max vehicle speed
    public float deadZone = 5f;       // Dead zone angle

    void Start()
    {

    }

    void Update()
    {
       
    }

    void FixedUpdate()
    {
        float angle = lever.localEulerAngles.x;
        if (angle > 180f) angle -= 360f;

        float forwardSpeed = 0f;
        float reverseSpeed = 0f;

        // Forward movement (0 to -45)
        if (angle > -45f + deadZone)
        {
            float t = Mathf.InverseLerp(-45f + deadZone, 0f, angle);
            forwardSpeed = t * maxSpeed;
        }

        // Reverse movement (-45 to -90)
        else if (angle < -45f - deadZone)
        {
            float t = Mathf.InverseLerp(-45f - deadZone, -90f, angle);
            reverseSpeed = t * maxSpeed;
        }

        vehicle.linearVelocity = vehicle.transform.forward * (forwardSpeed - reverseSpeed);

    }
}
