using UnityEngine;

public class LeverLiftController : MonoBehaviour
{
    public Transform lever;           // Lever's transform
    public GameObject lift;         // Vehicle's Rigidbody
    public float maxHeight = 9f;      // Max vehicle speed
    public float minHeight = 1.83f;

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
        float t = Mathf.InverseLerp(-90f, 0f, angle);

        lift.transform.localPosition = new Vector3(lift.transform.localPosition.x, Mathf.Lerp(minHeight,maxHeight,t), lift.transform.localPosition.z);
    }
}
