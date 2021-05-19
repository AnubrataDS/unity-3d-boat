using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterManager : MonoBehaviour
{
    private MeshFilter meshFilter;
    private Vector3[] initVertices;
    private void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        initVertices = meshFilter.mesh.vertices;
    }
    private void FixedUpdate()
    {
        // Vector3[] vertices = meshFilter.mesh.vertices;
        // for (int i = 0; i < vertices.Length; i++)
        // {
        //     vertices[i].y = initVertices[i].y + WaveManager.instance.GetWaveHeight(transform.position.x + vertices[i].x);
        // }
        // meshFilter.mesh.vertices = vertices;
        // meshFilter.mesh.RecalculateNormals();
    }
}
