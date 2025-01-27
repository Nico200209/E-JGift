using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFirstScene : MonoBehaviour
{
    public void LoadFirst()
    {
        // Reset time scale in case the game is paused
        Time.timeScale = 1;

        // Load the first scene (scene at index 0)
        SceneManager.LoadScene(0);
    }
}