﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    private float timeToSpawn = 2f;

    public float timeBetweenWaves = 1f;

    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
        
    }

    void SpawnBlocks()
    {
        int randomNumber = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomNumber != i)
            {
                //Instantiate a Block at a spawn point
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }

    
}
