using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton to easily access the score from anywhere
    public TMP_Text combinedScoreText; // Reference to the UI text for the total score

    private float totalScore = 0; // Shared total score

    private void Awake()
    {
        // Set up the Singleton pattern
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    // Method to add points to the shared score
    public void AddToScore(float points)
    {
        totalScore += points;
        UpdateScoreUI();
    }

    // Update the score display
    private void UpdateScoreUI()
    {
        combinedScoreText.text = "Total Score: " + totalScore;
    }
}