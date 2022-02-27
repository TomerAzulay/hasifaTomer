using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPicker : MonoBehaviour
{
    public GameObject[] itemsToPickFrom;
    // Start is called before the first frame update
    void Start()
    {
        Pick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Pick()
    {
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        GameObject clone = Instantiate(itemsToPickFrom[randomIndex], transform.position, Quaternion.identity);


    }
}
