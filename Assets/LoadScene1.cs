using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene1 : MonoBehaviour
{
    public void LoadSceneOne()
    {
        // Reset time scale in case the game is paused
        Time.timeScale = 1;

        // Load Scene 1
        SceneManager.LoadScene(1);
    }
    public void LoadSceneTwo()
    {
        // Reset time scale in case the game is paused
        Time.timeScale = 1;

        // Load Scene 2
        SceneManager.LoadScene(2);
    }
}