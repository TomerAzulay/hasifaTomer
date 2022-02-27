using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollDrop : MonoBehaviour
{
    public GameObject itemToSpread;
    public int numItemsToSpwan = 7;
    public float itemXSpread = 10f;
    public float itemYSpread = 0f;
    public float itemZSpread = 10f;
    public bool jumpScare;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpScare)
        {

            for (int i = 0; i < numItemsToSpwan; i++)
            {
                SpreadItem();
            }
        }

    }
}
