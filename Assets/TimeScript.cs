using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class TimeScript : MonoBehaviour
{
    public float totalTime = 60f;
    private float timeLeft;
    public TMP_Text timerText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
            timeLeft --;
            timerText.text = "Tiempo: " + timeLeft.ToString();
        }
        Time.timeScale = 0;
        Debug.Log("Time's up!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
