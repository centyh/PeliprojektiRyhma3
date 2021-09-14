using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpawner : MonoBehaviour
{
    public int timeToSpawn;
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;

    
    public float spawnNumber;
    public float spawnTimer;


    void Update()
    {
        SpawnObjects();
        
    }

    public void SpawnObjects()
    {
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        spawnTimer = Random.Range(0, 1000);

        float screenX, screenY;
        Vector2 pos;

        if(spawnNumber == spawnTimer)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
            
        }

        //for(int i = 0; i < timeToSpawn; i++)
        //{
        //    randomItem = Random.Range(0, spawnPool.Count);
        //    toSpawn = spawnPool[randomItem];

        //    screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
        //    screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
        //    pos = new Vector2(screenX, screenY);

        //    Instantiate(toSpawn, pos, toSpawn.transform.rotation);
            
        //}
    }

    

}
