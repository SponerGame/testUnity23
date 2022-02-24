using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshFilter))]
public class Bullet : MonoBehaviour
{
    public GameObject Object;
    public int count;
    Bull bull;
    Vector3[] newVertices;
    Vector2[] newUV;
    int[] newTriangles;
    Mesh mesh;

    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;


        newVertices = new Vector3[]
        {
            new Vector3(1,0,0),
            new Vector3(0,1,0),
            new Vector3(1,0,0)
        };

        newTriangles = new int[] { 1, 1 , 2 };

        UpdateMesh();
    }

    void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = newVertices;
        mesh.triangles = newTriangles;
        
    }

}

public struct BulletSystem
{
    public Vector2[] Points;
    public BulletSystem(Vector2[] vec)
    {
        this.Points = vec;
    }
}

public struct Bull
{
    public Sprite obj;

    public Bull(Sprite obj)
    {
        this.obj = obj;
    }
}