using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 18, -25);
    public float smoothSpeed = 0.125f;

    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        if (player != null)
        {
            Vector3 desiredPosition = player.transform.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);
        }
    }
}