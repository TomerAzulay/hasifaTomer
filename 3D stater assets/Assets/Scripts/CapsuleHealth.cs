using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleHealth : MonoBehaviour
{
    
    public int health = 5;
    public GameObject player;
    public GameObject itemToSpread;
    public int numItemsToSpwan = 7;
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
        GameObject clone = Instantiate(itemToSpread, randPosition + transform.position, Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MedKit"))
        {
            health++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            health--;
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (health<0)
        {
            Destroy(player);
            SpreadItem();
        }
    }
}
