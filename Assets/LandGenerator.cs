using UnityEngine;

public class EndlessBorders : MonoBehaviour
{
    public GameObject Border1;
    public GameObject Border2;

    public float speed = 5f;
    public float resetPositionZ = -100f;
    public float startPositionZ = 100f;

    void Update()
    {
        MoveAndResetTile(Border1, Border2);
        MoveAndResetTile(Border2, Border1);
    }

    private void MoveAndResetTile(GameObject current, GameObject other)
    {
        current.transform.position += Vector3.back * speed * Time.deltaTime;

        if (current.transform.position.z <= resetPositionZ)
        {
            float otherZ = other.transform.position.z;
            current.transform.position = new Vector3(
                current.transform.position.x,
                current.transform.position.y,
                otherZ + Mathf.Abs(startPositionZ - resetPositionZ)
            );
        }
    }
}