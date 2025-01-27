using System.Collections;
using UnityEngine;

public class DangerSpawnerP2 : MonoBehaviour
{
    public GameObject hardRock;
    public GameObject mediumRock;
    public GameObject smallRock;

    private float[] boatPositions = { -1066f, -1036f, -1006f }; // Possible boat x positions

    void Start()
    {
        StartCoroutine(SpawnCoinCoroutine());
    }

    IEnumerator SpawnCoinCoroutine()
    {
        while (true)
        {
            float randomNumber = Random.Range(0, 3);
            GameObject coinToSpawn = null;

            // Randomly pick which coin to spawn
            if (randomNumber == 0)
                coinToSpawn = hardRock;
            else if (randomNumber == 1)
                coinToSpawn = mediumRock;
            else if (randomNumber == 2)
                coinToSpawn = smallRock;

            // Randomly select a position from the predefined boat positions
            float xValue = boatPositions[Random.Range(0, boatPositions.Length)];

            // Spawn the selected coin
            Instantiate(coinToSpawn, new Vector3(xValue, -0.13f, 361.6f), Quaternion.identity);

            // Wait for a random time before spawning the next coin
            float delay = Random.Range(1f, 4f);
            yield return new WaitForSeconds(delay);
        }
    }
}