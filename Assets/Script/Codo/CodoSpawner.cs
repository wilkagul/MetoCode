using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodoSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public float spawnY = 4.25f;
    public float SpawnX = 2.0f;
    public Transform parentTransform; // Parent GameObject'in referansı
    public int maxEnemyCount = 50;

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

            // Pooldeki aktif enemy sayısını kontrol et
            int activeEnemyCount = 0;
            foreach (GameObject enemy in enemyPool)
            {
                if (enemy.activeInHierarchy)
                {
                    activeEnemyCount++;
                }
            }

            // Pooldeki aktif enemy sayısı maxEnemyCount'i geçmiyorsa yeni enemy oluştur
            if (activeEnemyCount < maxEnemyCount)
            {
                GameObject enemy = GetPooledEnemy();
                if (enemy != null)
                {
                    enemy.transform.position = new Vector3(SpawnX, spawnY, 0f);

                    // Parent GameObject'i ayarla
                    enemy.transform.SetParent(parentTransform);

                    enemy.SetActive(true);
                    SetText(enemy);
                }
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
        SetText(newEnemy);
        newEnemy.SetActive(false); // Başlangıçta false olarak ayarla
        enemyPool.Add(newEnemy);
        return newEnemy;
    }

    private void SetText(GameObject enemy)
    {
        int rndX = Random.Range(0, 3);
        string[] arr = LevelManager.Instance.GetOption();
        Transform transformObje = enemy.transform.GetChild(0);
        TextMeshPro textObje = transformObje.GetComponent<TextMeshPro>();
        textObje.text = arr[rndX];
    }
}
