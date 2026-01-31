//using System.Diagnostics;
using UnityEngine;

public class HandGrabSpriteChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] handArray;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spriteRenderer.sprite = handArray[1];
            Debug.Log("mouse butt down");
        }
        if (Input.GetMouseButtonUp(0))
        {
            spriteRenderer.sprite = handArray[0];
        }
    }

    //public void OnMouseDown()
    //{
    //    spriteRenderer.sprite = handArray[1];
    //    Debug.Log("mouse butt down");
    //}
    //public void OnMouseUp()
    //{
    //    spriteRenderer.sprite = handArray[0];
    //}
}
