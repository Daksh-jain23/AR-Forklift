using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringVehiclecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody vehicle;
    public float deadzone = 10f;
    public float rotationSpeed = 2.0f;
    private Vector3 originalRot;
    
    void Start()
    {
        originalRot = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = originalRot;
    }

    private void FixedUpdate()
    {
        float ang = transform.eulerAngles.z;
        if (ang > 180f) ang -= 360;
        vehicle.transform.Rotate(0f, -ang / 90 * rotationSpeed , 0f); 
    }
}
