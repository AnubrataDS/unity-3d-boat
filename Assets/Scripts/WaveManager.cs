using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;

    public float amplitude = 0.1f;
    public float length = 2f;
    public float speed = 1f;
    private float offset = 0f;


    private void Awake()
    {
        if (instance == null)
        {
            Debug.Log("Instance created");
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("Destroying duplicate instance");
            Destroy(this);
        }
    }
    private void Update()
    {
        offset += Time.deltaTime * speed;
    }

    public float GetWaveHeight(float x)
    {
        return (amplitude * Mathf.Sin(x / length + offset));
    }
}
