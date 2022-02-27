using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class testInput : MonoBehaviour
{
    private testInput Bob;
    public GameObject dropstospread;
    public int numdropstospawn;
    public float itemXSpread = 10f;
    public float itemYSpread = 0f;
    public float itemZSpread = 10f;

    
    
    public void SpreadItem()
    {
        Vector3 randPosition = new Vector3(
            Random.Range(-itemXSpread, itemXSpread)
            ,
            Random.Range(-itemYSpread, itemYSpread)
            ,
            Random.Range(-itemZSpread, itemZSpread)
            );
        GameObject clone = Instantiate(dropstospread, randPosition + transform.position, Quaternion.identity);
    }

   
    

    private void Update()
    {
        
    }
}

