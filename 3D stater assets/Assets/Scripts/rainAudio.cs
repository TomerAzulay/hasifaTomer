using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainAudio : MonoBehaviour
{
    public AudioSource jumpScare;
    
    private void OnTriggerEnter(Collider other)
    {
        jumpScare.Play();

        
    }
}
