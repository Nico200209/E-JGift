using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float speed = 1f; // Movement speed of the coin
    public int points = 1; // Points awarded for collecting the coin
    public AudioClip pickupSound; // Sound to play on coin pickup

    private AudioSource audioSource; // Audio source component

    void Start()
    {
        // Add an AudioSource component to the coin and configure it
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = pickupSound;
        audioSource.playOnAwake = false;
    }

    void FixedUpdate()
    {
        // Move the coin downward
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
        // Check if the object colliding is a player
        if (other.gameObject.name == "Player1" || other.gameObject.name == "Player2")
        {
            // Play the pickup sound
            if (pickupSound != null)
            {
                audioSource.Play();
            }

            // Add points to the shared GameManager score
            GameManager.Instance.AddToScore(points);

            // Destroy the coin after the sound finishes
            Destroy(gameObject, pickupSound.length);
        }
    }
}