using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 30;
    public float score = 0;
    public TMP_Text scoreText; // Changed from Text to TMP_Text

    void Start()
    {

    }

    void Update()
    {
        // Update the score text with TMP
        scoreText.text = "Puntos: " + score;

        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -20)
        {
            transform.position += new Vector3(-1 * speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 27)
        {
            transform.position += new Vector3(1 * speed, 0, 0);
        }
    }
}