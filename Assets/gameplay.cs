using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay : MonoBehaviour
{
    public int wasapiiHP = 10;
    public float spawnTime = 3f;
    public GameObject enemy;
    public Transform[] spawnPoints;


    private void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        if(wasapiiHP <= 0){
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Vector3 randomPoint = spawnPoints[spawnPointIndex].position;
        switch (spawnPoints[spawnPointIndex].name){
            case "SpawnPoint_top":
            case "SpawnPoint_bottom":
                randomPoint = randomPoint + new Vector3(Random.Range(-380.0f, 380.0f), 0, 0);
                break;
            case "SpawnPoint_left":
            case "SpawnPoint_right":
                randomPoint = randomPoint + new Vector3(0, Random.Range(-200.0f, 200.0f), 0);
                break;
        }

        Instantiate(enemy, randomPoint, spawnPoints[spawnPointIndex].rotation);
    }
}
