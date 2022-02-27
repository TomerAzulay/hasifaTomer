using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Flashlight : MonoBehaviour
{
    bool isOn = false;
    public GameObject flashLight;
    public bool failSafe = false;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            if (isOn == false && failSafe == false)
            {
                failSafe = true;
                flashLight.SetActive(true);
                isOn = true;
                StartCoroutine(FailSafe());
            }

            if (isOn == true && failSafe == false)
            {
                failSafe = true;
                flashLight.SetActive(false);
                isOn = false;
                StartCoroutine(FailSafe());
            }
        }

    }

    IEnumerator FailSafe()
    {
        yield return new WaitForSeconds(0.1f);
        failSafe = false;
}
}
