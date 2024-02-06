using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public bool isSpawning = false;
    public float enemyInterval = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isSpawning = true;
            StartCoroutine(SpawnEnemy(enemyInterval, enemyPrefab));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isSpawning = false;
        }
    }

    private IEnumerator SpawnEnemy(float interval, GameObject enemy)
    {
        while (isSpawning)
        {
            yield return new WaitForSeconds(interval);
            GameObject newEnemy = Instantiate(enemy, transform.position, Quaternion.identity);
        }
    }
}
