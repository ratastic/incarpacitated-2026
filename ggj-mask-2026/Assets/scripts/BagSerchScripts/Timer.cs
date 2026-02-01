using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
 //   public string LeveltoLoad;
    // Image timerBar;
    public float timer = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            FindFirstObjectByType<BadOGood>().LoadBadEnding();
            enabled = false;

        }
    }
}
