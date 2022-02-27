using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class itemAreaSpawner : MonoBehaviour
{
    public GameObject itemToSpread;
    public int numItemsToSpwan = 30;
    public float itemXSpread = 10f;
    public float itemYSpread = 0f;
    public float itemZSpread = 10f;
    public bool rain;
    void SpreadItem()
    {
        Vector3 randPosition = new Vector3(
            Random.Range(-itemXSpread, itemXSpread)
            ,
            Random.Range(-itemYSpread, itemYSpread)
            ,
            Random.Range(-itemZSpread, itemZSpread)
            );
        GameObject clone = Instantiate(itemToSpread, randPosition + transform.position, Quaternion.identity);
    }

    
    // Update is called once per frame
    void Update()
    {
        if (rain)
        {

            for (int i = 0; i < numItemsToSpwan; i++)
            {
                SpreadItem();
            }
        }
    }
}
