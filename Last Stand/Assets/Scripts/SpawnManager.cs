using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is used to spawn enemies at random positions around the tower

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject tower;
    private float spawnRadius = 50f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 towerPosition = tower.transform.position;

    for (int enemyIndex = 0; enemyIndex < enemies.Length; enemyIndex++)
    {
        float angle = enemyIndex * Mathf.PI * 2 / enemies.Length;
        Vector3 spawnPosition = new Vector3(
            Mathf.Cos(angle) * spawnRadius,
            0,
            Mathf.Sin(angle) * spawnRadius
        );

        enemies[enemyIndex].transform.position = towerPosition + spawnPosition;
    }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
