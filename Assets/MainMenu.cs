using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Load the next scene
        SceneManager.LoadScene(1);
    }
    public void PlayCollection()
    {
        // Load the next scene
        SceneManager.LoadScene(2);
    }
}

