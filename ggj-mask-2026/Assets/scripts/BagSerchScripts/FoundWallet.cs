using UnityEngine;
using UnityEngine.SceneManagement;

public class FoundWallet : MonoBehaviour
{
    private Animator anim;

    public AudioClip clickSFX;
    private AudioSource audioSource;

    public SpriteRenderer spriteRenderer;
    public Sprite[] walletArray;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        anim.Play("backsearch-wallet-anime");
        if (clickSFX != null)
            audioSource.PlayOneShot(clickSFX);

    }

    public void LoadScene(string SceneName)
    {
        FindFirstObjectByType<BadOGood>().LoadGoodEnding();
        enabled = false;
    }

    public void SwapSprite()
    {
        spriteRenderer.sprite = walletArray[1];
    }

}
