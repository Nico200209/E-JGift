using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 30;

    void Update()
    {
        // Player movement logic
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