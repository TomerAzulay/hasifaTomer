using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScale : MonoBehaviour
{
    public bool cScale;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cScale)
        {
            transform.localScale = new Vector3(Random.Range(1,4), Random.Range(1, 4), Random.Range(1, 4));
        }
    }
}
