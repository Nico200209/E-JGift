using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed = 30;

    void Update()
    {
        // Player movement logic
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -1060)
        {
            transform.position += new Vector3(-1 * speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < -1010)
        {
            transform.position += new Vector3(1 * speed, 0, 0);
        }
    }
}