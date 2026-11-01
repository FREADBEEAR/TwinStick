using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float SpawnDelay;
    [SerializeField] private GameObject[] spawnpoints;
    private List<GameObject> enemies = new List<GameObject>();
    
    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            for (int i = 0; i < spawnpoints.Length; i++)
            {
                if (spawnpoints[i] != null)
                {
                    GameObject newestEnemy = Instantiate(enemy, spawnpoints[i].transform.position, spawnpoints[i].transform.rotation);
                    enemies.Add(newestEnemy);
                }

                yield return new WaitForSeconds(SpawnDelay);
            }
        }
    }

    void Start()
    {
        Debug.Log("EnemySpawner STARTED");
        StartCoroutine(SpawnEnemies());
    }

     void Update()
    {
        Debug.Log("There are currently " + enemies.Count + "enemies in the game.");

        for (int i = enemies.Count - 1; i >= 0; i--)
        {
            if (enemies[i] == null)
            {
                enemies.RemoveAt(i);
            }
        }
    }
    
        
    
}


   
