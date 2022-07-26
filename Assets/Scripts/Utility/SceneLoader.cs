using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneByName(string name)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(name);
    }
}
