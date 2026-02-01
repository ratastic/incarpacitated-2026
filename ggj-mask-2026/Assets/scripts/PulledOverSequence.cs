using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PulledOverSequence : MonoBehaviour
{
    public GameObject blueLight;
    public GameObject redLight;
    private float pause = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CopLights());
    }

    private IEnumerator CopLights()
    {
        yield return new WaitForSeconds(pause);
        
        Debug.Log("detected by cop");
        blueLight.SetActive(true);
        redLight.SetActive(true);
        
        yield return new WaitForSeconds(pause);
        Debug.Log("add transition into next scene");
    }

}
