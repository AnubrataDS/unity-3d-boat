using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatControl : MonoBehaviour
{
    [SerializeField]
    public float accel;
    public float rotateSpeed;
    private Rigidbody rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isOnWater())
        {
            float throttle = Input.GetAxisRaw("Throttle");
            if (throttle > 0.5f || throttle < -0.5f)
            {
                rigidBody.AddForce(transform.forward * throttle * accel, ForceMode.Acceleration);
            }

        }
        float turn = Input.GetAxisRaw("Sideways");
        if (turn > 0.5f || turn < -0.5f)
        {
            rigidBody.AddTorque(transform.up * turn * rotateSpeed, ForceMode.Acceleration);
        }
    }
    private bool isOnWater()
    {
        return Physics.Raycast(transform.position + new Vector3(0, transform.lossyScale.y * 0.5f, 0), -Vector3.up, transform.lossyScale.y + 0.2f, LayerMask.GetMask("Water"));
    }
}
