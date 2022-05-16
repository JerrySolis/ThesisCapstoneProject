using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawngerms : MonoBehaviour
{
    public static spawngerms Instance;
    public Transform[] spawnPoints;
    public Transform[] germs;
    int randomSpawnPoint, randomGerms;
    public static bool spawnAllowed;
    public float SpawnTime;
    private int Counts = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnGerms", 0f, SpawnTime);
    }
    void Awake()
    {
        Instance = this;    
    }



    void SpawnGerms()
    {
        if (spawnAllowed)
        {
            if (spawnAllowed)
            {
                randomSpawnPoint = Random.Range(0, spawnPoints.Length);
                randomGerms = Random.Range(0, germs.Length);
                Instantiate(germs[randomGerms], spawnPoints[randomSpawnPoint].position, Quaternion.identity, transform.parent);
                Counts++;
                Debug.Log("Spawned germs: " + Counts);
            }
        }
    }

    // Update is called once per frame
     void Update()
     {
        if (Counts >= 29)
        {
            spawnAllowed = false;
        }
              
     }
}
