using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioJumpScare : MonoBehaviour
{
    public AudioSource jumpScare;
    public GameObject theplayer ;
    private void OnTriggerEnter(Collider other)
    {
        jumpScare.Play();
        
        StartCoroutine(EndJump());
    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(3f);



    }
    
}
