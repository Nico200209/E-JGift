using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public PlayerController playerController;
    public float speed = 1f; // Movement speed of the coin
    public int points = 1; // Points awarded for collecting the coin

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void FixedUpdate()
    {
        if (transform.position.z > -240)
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            playerController.score += points; // Add points based on the coin type
            Destroy(gameObject);
        }
    }
}