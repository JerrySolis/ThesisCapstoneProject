using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GermSpawner : MonoBehaviour
{
    [SerializeField]private GameObject Salmonella;
   // [SerializeField] private GameObject Campylobacter;
   // [SerializeField] private GameObject Shigella;

    [SerializeField] private float SalmonellaInterval = 3.5f;
  //  [SerializeField] private float CampylobacterInterval = 5.5f;
   // [SerializeField] private float ShigellaiInterval = 8.5f;
    
    
    private IEnumerator spawnGerms(float interval, GameObject germs)
    {
        yield return new WaitForSeconds(interval);
        //Create new GameObject enemy on particular position and Quaternion identity is the rotation where to  spawn
        GameObject newGerms = Instantiate(germs, new Vector3(Random.Range(-187f, 110f), Random.Range(-182f, 112f)), Quaternion.identity);
        StartCoroutine(spawnGerms(interval, germs)); 
    }
    
    
    
    
    void Start()
    {
        StartCoroutine(spawnGerms(SalmonellaInterval, Salmonella));
       // StartCoroutine(spawnGerms(CampylobacterInterval, Campylobacter));
        //StartCoroutine(spawnGerms(ShigellaiInterval, Shigella));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
