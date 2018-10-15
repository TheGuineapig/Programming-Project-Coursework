using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float angle = 15f;
    public Vector3 axis = Vector3.up;
    
    void Update()
    {
        transform.Rotate(axis, angle);
    }
}
