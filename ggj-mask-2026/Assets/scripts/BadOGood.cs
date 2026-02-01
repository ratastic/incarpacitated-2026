using UnityEngine;

public class BadOGood : MonoBehaviour
{

    public string goodEndingScene;
    public string badEndingScene;

    SceneFade fade;

    void Awake()
    {
        fade = FindFirstObjectByType<SceneFade>();
    }

    public void LoadGoodEnding()
    {
        fade.StartFade(goodEndingScene);
    }

    public void LoadBadEnding()
    {
        fade.StartFade(badEndingScene);
    }
}


