using UnityEngine;
using UnityEngine.SceneManagement;

public class FoundWallet : MonoBehaviour
{
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        anim.SetBool("FoundWallet", true);
    }

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        //copCollission.Alive();
    }


}
