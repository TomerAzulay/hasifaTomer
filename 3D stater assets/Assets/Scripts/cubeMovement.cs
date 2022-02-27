using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    public Transform cube;
    public float speed;
    void cubeud()
    {
        transform.position += Vector3.up * Time.deltaTime;

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, cube.position, step);
    }
}
