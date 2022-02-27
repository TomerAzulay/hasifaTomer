using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onOffGlow : MonoBehaviour
{
    MeshRenderer meshrenderer;
    bool powerTime;
    // Start is called before the first frame update
    void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (powerTime)
        {
            meshrenderer.material.SetFloat("Vector1_e821ecc71c534243b66bfa0f6878db6c", meshrenderer.material.GetFloat("Vector1_e821ecc71c534243b66bfa0f6878db6c") + 0.1f);
            if (meshrenderer.material.GetFloat("Vector1_e821ecc71c534243b66bfa0f6878db6c") >= 1.45f)

                powerTime = false;
        }
        else
        {
            meshrenderer.material.SetFloat("Vector1_e821ecc71c534243b66bfa0f6878db6c", meshrenderer.material.GetFloat("Vector1_e821ecc71c534243b66bfa0f6878db6c") - 0.1f);
            if (meshrenderer.material.GetFloat("Vector1_e821ecc71c534243b66bfa0f6878db6c") <= -2)

                powerTime = true;


        }
    }
    }


