using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeUpDown : MonoBehaviour
{
    private float movementSpeed = 5f;



    void Start()
    {
        
    }

    void Update()
    {
        
        GameObject cubeMove = (gameObject);
        cubeMove.transform.position = transform.position + new Vector3(20, 0, 0);
        cubeMove.transform.position = transform.position + new Vector3(9, 0, 0);
        Debug.Log(transform.position);

    }
}
