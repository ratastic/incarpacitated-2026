using UnityEngine;
using UnityEngine.SceneManagement;

public class wallet : MonoBehaviour
{
    public string LeveltoLoad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        SceneManager.LoadScene(LeveltoLoad);
    }
}
