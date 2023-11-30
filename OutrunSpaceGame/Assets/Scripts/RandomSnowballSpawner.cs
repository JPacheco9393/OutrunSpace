using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSnowballSpawner : MonoBehaviour
{
    [SerializeField] GameObject snowPrefab;
    [SerializeField] int poolSize = 10;

    private List<GameObject> snowballPool = new List<GameObject>();

    void Start()
    {
        InitializeObjectPool();
        SpawnSnowballsOverTime();
    }

    void InitializeObjectPool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject snowball = Instantiate(snowPrefab, Vector3.zero, Quaternion.identity);
            snowball.SetActive(false);
            snowballPool.Add(snowball);
        }
    }

    void SpawnSnowballsOverTime()
    {
        StartCoroutine(SpawnSnowballsOverTimerRoutine());
    }

    IEnumerator SpawnSnowballsOverTimerRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);

            // Find an inactive snowball from the pool
            GameObject snowball = GetInactiveSnowball();

            if (snowball != null)
            {
                snowball.transform.position = new Vector3(Random.Range(-100, 100), 5, 0);
                snowball.SetActive(true);

                // Set a timer to return the snowball to the pool
                StartCoroutine(ReturnSnowballToPool(snowball));
            }
        }
    }

    GameObject GetInactiveSnowball()
    {
        foreach (var snowball in snowballPool)
        {
            if (!snowball.activeSelf)
            {
                return snowball;
            }
        }
        return null;
    }

    IEnumerator ReturnSnowballToPool(GameObject snowball)
    {
        yield return new WaitForSeconds(10);
        snowball.SetActive(false);
    }
}