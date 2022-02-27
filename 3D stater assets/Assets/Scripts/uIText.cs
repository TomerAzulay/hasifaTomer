using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uIText : MonoBehaviour
{
    int health = 10;
    public Text healthtext;

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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthtext.text = health.ToString();
    }
}
