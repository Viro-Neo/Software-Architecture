using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField]
    public Transform enemyPrefab;
    
    [SerializeField]
    private Transform spawnPoint;
    
    [SerializeField]
    private float timeBetweenWaves = 5f;

    private float countdown = 2f;
    
    [SerializeField]
    private TextMeshProUGUI waveCountdownTimer;
    
    private int waveIndex = 0;
    
    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;   
        waveCountdownTimer.text = Mathf.Round(countdown).ToString();
    }
    
    IEnumerator SpawnWave()
    {
        for (var i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }

        waveIndex++;
    }
    
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
