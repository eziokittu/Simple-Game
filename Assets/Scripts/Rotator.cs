using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public bool rotateClockWise = true;
    public float turnSpeed = 100f;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if (rotateClockWise == true)
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        else transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
    }
}
