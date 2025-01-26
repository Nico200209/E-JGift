using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 30;
    public float score = 0;
    public Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
