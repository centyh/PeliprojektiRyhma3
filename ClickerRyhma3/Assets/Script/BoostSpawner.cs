using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpawner : MonoBehaviour
{
    public int timeToSpawn;
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;

    float spawnTime = 70f;
    float curSpawnTime;

    private void Start()
    {
        curSpawnTime = spawnTime;
    }

    void Update()
    {
        SpawnObjects();
        
    }

    public void SpawnObjects()
    {
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        //spawnTimer = Random.Range(0, 50000);

        float screenX, screenY;
        Vector2 pos;

        curSpawnTime -= Time.deltaTime;

        if(curSpawnTime <= 0)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            Destroy(Instantiate(toSpawn, pos, toSpawn.transform.rotation), 4f);

            curSpawnTime = spawnTime;
            
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
