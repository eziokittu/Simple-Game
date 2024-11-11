using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour
{
    public Texture[] groundTextures;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            int x = UnityEngine.Random.Range(0, groundTextures.Length); // all grounds same texture on that scene
            GameObject[] grounds =  GameObject.FindGameObjectsWithTag("Ground");
            foreach (GameObject g in grounds)
            {
                //int x = UnityEngine.Random.Range(0, groundTextures.Length*10) % groundTextures.Length; // texture not same on all grounds
                g.GetComponent<Renderer>().material.mainTexture = groundTextures[x];
            }
        }
        catch (Exception e)
        {
            Debug.Log("No Textures found / Error in getting texture.\nExcemption : " + e);
        }
    }
}
