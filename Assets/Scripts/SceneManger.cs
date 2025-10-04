using UnityEngine;
 using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{
    public void ReloadScene()
    {
        SceneManager.LoadScene("cars");
    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
