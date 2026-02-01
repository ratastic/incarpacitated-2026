using UnityEngine;

public class JitterText : MonoBehaviour
{
    public float shakeSpeed;
    private Vector3 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.localPosition; //Get text position
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = startPos + (Vector3)Random.insideUnitCircle * shakeSpeed; //Unit circle = Random unit range of 1
    }
}
