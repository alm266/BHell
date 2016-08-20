﻿using UnityEngine;
using System.Collections;
//GameController responsibilties
//******************************
//spawn waves
//track scoring
//determine start and end conditions


public class GameController : MonoBehaviour
{
    public GameObject hazard; //choosing a hazard.  Will need an array later so we can randomize this

    public float spawnWait;  //wait time between spawning
    public float startWait; //wait time at start
    public float waveWait;  //wait time between waves


    public int maxHazardSpawnCount; //maximum number of hazards per wave  

   
	// Use this for initialization
	void Start ()
    {
        //while(!Input.GetButton("Cancel")) //default set to Esc key
    
        {
            StartCoroutine( SpawnWaves()); //spawning is a coroutine
          
        }
	}

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            
            int hazardSpawnCount = Random.Range(0, maxHazardSpawnCount);
            for (int i = 0; i < hazardSpawnCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-28, 28), 0, Random.Range(23, 83));  //some defined spawn area
                Quaternion spawnRotation = hazard.transform.rotation;  //whatever the set rotation was 
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);  //wait between each spawn
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}
