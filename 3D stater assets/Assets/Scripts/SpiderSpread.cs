using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderSpread : MonoBehaviour
{
    public GameObject itemToSpread;
    public int numItemsToSpwan = 1;
    public float itemXSpread = 1f;
    public float itemYSpread = 0f;
    public float itemZSpread = 1f;
    
    public void SpreadItem()
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
}
