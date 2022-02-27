using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleBy : MonoBehaviour
{
    public GameObject cube;
    Vector3 scaleChange;
    private void Awake()
    {
        
        scaleChange = new Vector3(-0.1f, -0.1f, -0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.localScale += scaleChange;
        if (cube.transform.localScale.y<0.1f|| cube.transform.localScale.y>1f)
        {
            scaleChange = -scaleChange;
        }
    }
}
