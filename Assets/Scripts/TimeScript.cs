using System.Collections;
using TMPro;
using UnityEngine;

public class TimeScript : MonoBehaviour
{
    public float totalTime = 60f;
    private float timeLeft;
    public TMP_Text timerText;

    // UI elements to activate/deactivate
    public GameObject gameUI; // The active game UI
    public GameObject gameOverUI; // The game-over UI to show when the time is up

    void Start()
    {
        timeLeft = totalTime;
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1f);
            timeLeft--;
            timerText.text = "" + timeLeft.ToString();
        }

        // Time's up! Activate and deactivate the required UI elements
        Time.timeScale = 0; // Pause the game
        gameUI.SetActive(false); // Deactivate the game UI
        gameOverUI.SetActive(true); // Activate the game-over UI
        Debug.Log("Time's up! Game Over.");
    }
}