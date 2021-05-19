using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    public Rigidbody rigidBody;
    public GameObject waterCube;
    public float depthBeforeSubmerged = 1f;
    public float displacementAmount = 1f;
    private float waterCubeTop;
    public int floaterCount = 1;
    public float waterAngularDrag = 0.5f;
    public float waterDrag = 0.99f;
    private void Start()
    {
        waterCubeTop = waterCube.transform.position.y + (waterCube.transform.lossyScale.y / 2);
        Debug.Log(waterCubeTop);
    }
    private void FixedUpdate()
    {
        rigidBody.AddForceAtPosition(Physics.gravity / floaterCount, transform.position, ForceMode.Acceleration);
        float checkTop = waterCubeTop + WaveManager.instance.GetWaveHeight(transform.position.x);
        if (transform.position.y < checkTop)
        {
            float displacementMultiplier = Mathf.Clamp01((checkTop - transform.position.y) / depthBeforeSubmerged) * displacementAmount;
            rigidBody.AddForceAtPosition(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f), transform.position, ForceMode.Acceleration);
        }
    }

}
