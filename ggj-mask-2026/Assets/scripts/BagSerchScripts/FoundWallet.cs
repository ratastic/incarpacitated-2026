using UnityEngine;
using UnityEngine.SceneManagement;

public class FoundWallet : MonoBehaviour
{
    private Animator anim;

    public SpriteRenderer spriteRenderer;
    public Sprite[] walletArray;
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
        anim.Play("backsearch-wallet-anime");
    }

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        //copCollission.Alive();
    }

    public void SwapSprite()
    {
        spriteRenderer.sprite = walletArray[1];
    }

}
