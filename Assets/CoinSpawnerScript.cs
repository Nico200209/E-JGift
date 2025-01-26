using System.Collections;
using UnityEngine;

public class CoinSpawnerScript : MonoBehaviour
{
    public GameObject coinPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnCoinCourutine());
    }

    IEnumerator SpawnCoinCourutine()
    {
        while (true)
        {
            float randomNumber = Random.Range(0, 3);
            if (randomNumber == 0)
                StartCoroutine(SpawnCoin(-30f));
            if (randomNumber == 1)
                StartCoroutine(SpawnCoin(0f));
            if (randomNumber == 2)
                StartCoroutine(SpawnCoin(30f));

            float delay = Random.Range(1f, 4f);
            yield return new WaitForSeconds(delay);
        }
    }

    IEnumerator SpawnCoin(float xValue)
    {
        yield return new WaitForSeconds(3f);
        Instantiate(coinPrefab, new Vector3(xValue, -0.13f, 361.6f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
