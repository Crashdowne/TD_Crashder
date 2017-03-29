using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;
    public string startString = "Level01";

    public void LoadScene ()
    {
        SceneManager.LoadScene(startString);
    }

    public void ExitGame ()
    {
        Application.Quit();
    }

}
