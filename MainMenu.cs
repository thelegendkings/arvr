using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("Scene3");
    }
}
