using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] boosts;
    private int numberToSpawn = 7;
    private int rand;
    



    void Start()
    {
        
    }

    
    void Update()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        rand = Random.Range(0, 10000);

        if(rand == numberToSpawn)
        {
            Instantiate(boosts[0], transform.position, Quaternion.identity);
            Debug.Log("Kolikko boosti spawnattu");
        }
    }
}
