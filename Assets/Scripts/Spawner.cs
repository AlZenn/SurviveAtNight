using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    /*
    public GameObject enemyPrefab;
    public float spawnDelay = 5f;

    private float timeSinceLastSpawn = 0f;
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnDelay)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0f;
        }
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }
    */
    public GameObject enemyPrefab;
    public float spawnDelay = 5f;
    public float spawnRadius = 10f;
    public string playerTag = "Player";
    public float increaseDel;

    private float timeSinceLastSpawn = 0f;
    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag(playerTag).transform;

        InvokeRepeating("increaseDelay", 2f, 5f);
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnDelay)
        {
            SpawnEnemy();
            timeSinceLastSpawn = 0f;
        }
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = playerTransform.position + Random.insideUnitSphere * spawnRadius;
        spawnPosition.y = Mathf.Max(spawnPosition.y, 1f);
        spawnPosition.z = Mathf.Max(spawnPosition.z, -15f);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
    void increaseDelay()
    {
        if (spawnDelay > 3f)
        {

        

        spawnDelay = spawnDelay - increaseDel;
        Debug.Log(increaseDel);
        }
    }

}

