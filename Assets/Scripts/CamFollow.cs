using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject followThis;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = followThis.transform.position;
        this.transform.eulerAngles = new Vector3(0, followThis.transform.eulerAngles.y, 0);
    }
}
