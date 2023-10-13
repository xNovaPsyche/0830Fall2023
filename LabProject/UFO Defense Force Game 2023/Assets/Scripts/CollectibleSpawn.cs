using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawn : MonoBehaviour
{
    public GameObject[] collectiblePrefabs;

    private float spawnRangeX = 20f;

    private float spawnPosZ = 20f;

    private float startDelay = 2f;

    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomCollectible", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomCollectible()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int collectibleIndex = Random.Range(0, collectiblePrefabs.Length);
        Instantiate(collectiblePrefabs[collectibleIndex], spawnPos, collectiblePrefabs[collectibleIndex].transform.rotation);
    }
}