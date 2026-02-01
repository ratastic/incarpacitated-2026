using UnityEngine;
using System.Collections;

public class PulledOverSequence : MonoBehaviour
{
    public GameObject blueLight;
    public GameObject redLight;
    private float pause = 5f;
    private float pause2 = 6f;

    void Start()
    {
        StartCoroutine(CopLights());
    }

    private IEnumerator CopLights()
    {
        yield return new WaitForSeconds(pause2);

        Debug.Log("detected by cop");
        blueLight.SetActive(true);
        redLight.SetActive(true);

        yield return new WaitForSeconds(pause);

        SceneFade fade = FindFirstObjectByType<SceneFade>();
        fade.StartFade("Talking");
    }
}
