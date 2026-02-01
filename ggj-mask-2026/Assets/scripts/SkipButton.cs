using UnityEngine;

public class SkipButton : MonoBehaviour
{
    public GameObject skipButton;

    public string seenKey = "DrivingIntro";

    void Start()
    {
        bool hasSeenIntroBefore = PlayerPrefs.HasKey(seenKey);

        if (hasSeenIntroBefore)
        {
            ShowSkipButton();
        }
        else
        {
            HideSkipButton();
            MarkIntroAsSeen();
        }
    }

    void ShowSkipButton()
    {
        skipButton.SetActive(true);
    }

    void HideSkipButton()
    {
        skipButton.SetActive(false);
    }

    void MarkIntroAsSeen()
    {
        PlayerPrefs.SetInt(seenKey, 1);
        PlayerPrefs.Save();
    }
}
