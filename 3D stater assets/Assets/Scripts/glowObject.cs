using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glowObject : MonoBehaviour
{
    MeshRenderer meshRenderer;
    bool glowiness;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PuzzleRed"))
        {
            meshRenderer.material.SetFloat("Vector1_6912ecfed80146789a93f99cb2934f2b", + 5f);
            if (meshRenderer.material.GetFloat("Vector1_6912ecfed80146789a93f99cb2934f2b")>=100)
            {
                meshRenderer.material.SetFloat("Vector1_6912ecfed80146789a93f99cb2934f2b", - 5f);
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PuzzleRed"))
        {
            meshRenderer.material.SetFloat("Vector1_6912ecfed80146789a93f99cb2934f2b", 0);
        }
    }
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
