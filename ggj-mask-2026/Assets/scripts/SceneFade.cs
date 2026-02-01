using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneFade : MonoBehaviour
{
    public CanvasGroup fadeGroup;


    public string nextSceneName;

    public float fadeDuration = 1f;

    void Start()
    {
        fadeGroup.alpha = 0f;
    }

    public void FadeToNextScene()
    {
        StartCoroutine(FadeSequence(nextSceneName));
    }
    public void StartFade(string sceneToLoad)
    {
        StartCoroutine(FadeSequence(sceneToLoad));
    }

    IEnumerator FadeSequence(string sceneToLoad)
    {
        yield return StartCoroutine(Fade(0f, 1f));
        SceneManager.LoadScene(sceneToLoad);
    }

    IEnumerator Fade(float start, float end)
    {
        float t = 0f;

        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            fadeGroup.alpha = Mathf.Lerp(start, end, t / fadeDuration);
            yield return null;
        }

        fadeGroup.alpha = end;
    }
}
