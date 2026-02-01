using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneName;

    public void LoadSceneByName()
    {
        SceneManager.LoadScene(sceneName);
    }
}