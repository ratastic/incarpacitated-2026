using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
 //   public string LeveltoLoad;
    // Image timerBar;
    public float timer = 10f;
    public GameObject warningPopup;

    private bool popupShown = false;

    public AudioClip clickSFX;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        warningPopup.SetActive(false);
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 3f && !popupShown)
        {
            warningPopup.SetActive(true);

            if (clickSFX != null)
                audioSource.PlayOneShot(clickSFX);

            popupShown = true;
        }

        if (timer <= 0)
        {
            FindFirstObjectByType<BadOGood>().LoadBadEnding();
            enabled = false;

        }
    }
}
