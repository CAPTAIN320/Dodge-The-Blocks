using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    // Start is called before the first frame update
    void Start()
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
