using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public float spawnHeight = 10f;
    public float minSpawnX = -2.5f;
    public float maxSpawnX = 2.5f;
    public Transform parentTransform; // Parent GameObject'in referansı

    private List<GameObject> enemyPool = new List<GameObject>();

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            GameObject enemy = GetPooledEnemy();
            if (enemy != null)
            {
                float randomX = Random.Range(minSpawnX, maxSpawnX);
                enemy.transform.position = new Vector3(randomX, spawnHeight, 0f);

                // Parent GameObject'i ayarla
                enemy.transform.SetParent(parentTransform);

                enemy.SetActive(true);
            }
        }
    }

    private GameObject GetPooledEnemy()
    {
        foreach (GameObject enemy in enemyPool)
        {
            if (!enemy.activeInHierarchy)
            {
                return enemy;
            }
        }

        // Eğer aktif bir enemy yoksa yeni bir enemy oluştur
        GameObject newEnemy = Instantiate(enemyPrefab);
        enemyPool.Add(newEnemy);
        return newEnemy;
    }
}
