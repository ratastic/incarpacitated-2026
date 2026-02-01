using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string scnName;

    public void LoadSceneByName()
    {
        SceneManager.LoadScene(scnName);
    }
}