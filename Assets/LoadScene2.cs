using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene2 : MonoBehaviour
{
    public void LoadSceneTwo()
    {
        // Reset time scale in case the game is paused
        Time.timeScale = 1;

        // Load Scene 2
        SceneManager.LoadScene(2);
    }
}