using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset ;

    private void Start()
    {
        try 
        {
            Light light = GetComponent<Light>();
            light.range = 5.6f;
            light.intensity = 35;
        }
        catch (Exception e)
        {
            Debug.Log("The gameobject : " + transform.name + " has no 'component' of type <Light> attached to it.\nException : " + e);
        }
    }

    private void LateUpdate()
    {
        GameObject scenePlayer = GameObject.Find("Player");
        // transform.position = target.position + offset;
        transform.position = scenePlayer.transform.position + offset;
    }
}