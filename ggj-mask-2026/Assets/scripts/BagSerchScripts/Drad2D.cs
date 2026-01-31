using UnityEngine;
using UnityEngine.SceneManagement;

public class Drad2D : MonoBehaviour
{
    private bool dragging = false;
    private Vector3 offset;

    public string LeveltoLoad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

    public void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
        Debug.Log("clicked");
    }

    private void OnMouseUp()
    {
        dragging = false;
    }
}
