﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{

    public GameObject[] spawnPoint;
    public GameObject[] Eggs;
    public GameObject changer;

    public SpawnStarter spawnStarter;

    private int patternToSpawn;

    public float timeBetweenChanger;
    private float timeChanger;

    //used for random variation in lines
    private int index0, index1, index2, index3, index4;

    private void Start()
    {
        spawnStarter.canSpawn = true;
        patternToSpawn = 0;
    }

    private void Update()
    {
     


      if (spawnStarter.canSpawn)
        {
            patternToSpawn = Random.Range(0, 5);

         

            if (patternToSpawn == 0)
            {
                StraightLine1();
            }

            if (patternToSpawn == 1)
            {
                StraightLine2();
            }

            if (patternToSpawn == 2)
            {
                ZigZag1();
            }

            if (patternToSpawn == 3)
            {
                ZigZag2();
            }

           if (patternToSpawn == 4 && Time.time >= timeChanger)
           {
               timeChanger = Time.time + timeBetweenChanger;
               ChangerStraight();
           }
           else
           {
              patternToSpawn = Random.Range(0, 5);
           }

        }

    }


    
    public void StraightLine1()
    {
        spawnStarter.canSpawn = false;
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], spawnPoint[0].transform.position, Quaternion.identity);
        Instantiate(Eggs[Player.currentColor], spawnPoint[1].transform.position, Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], spawnPoint[2].transform.position, Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], spawnPoint[3].transform.position, Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)],spawnPoint[4].transform.position, Quaternion.identity);
    }

    //straight line with only one right color
    public void StraightLine2()
    {
        int randomColorIndex;
        spawnStarter.canSpawn = false;


        do
        {
            randomColorIndex = Random.Range(0, 5);
        } while (randomColorIndex == Player.currentColor);
        {
            Instantiate(Eggs[randomColorIndex], spawnPoint[0].transform.position, Quaternion.identity);
            Instantiate(Eggs[randomColorIndex], spawnPoint[1].transform.position, Quaternion.identity);
            Instantiate(Eggs[randomColorIndex], spawnPoint[2].transform.position, Quaternion.identity);
            Instantiate(Eggs[Player.currentColor], spawnPoint[3].transform.position, Quaternion.identity);
            Instantiate(Eggs[randomColorIndex], spawnPoint[4].transform.position, Quaternion.identity);
        }
        
    }

    //dont apply random modifier here
    public void ZigZag1()

    {
        spawnStarter.canSpawn = false;
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[0].transform.position.x, spawnPoint[0].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[1].transform.position.x + 1.5f, spawnPoint[1].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Player.currentColor], new Vector2(spawnPoint[2].transform.position.x + 3f, spawnPoint[2].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[3].transform.position.x + 4.5f, spawnPoint[3].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[4].transform.position.x + 6f, spawnPoint[4].transform.position.y), Quaternion.identity);

    }

    public void ZigZag2()
    {
        spawnStarter.canSpawn = false;
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[0].transform.position.x + 6f, spawnPoint[0].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[1].transform.position.x + 4.5f, spawnPoint[1].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Player.currentColor], new Vector2(spawnPoint[2].transform.position.x + 3f, spawnPoint[2].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[3].transform.position.x + 1.5f, spawnPoint[3].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[4].transform.position.x, spawnPoint[4].transform.position.y), Quaternion.identity);
    }

    public void ChangerStraight()
    {
        int currentSpawn = 0;
        spawnStarter.canSpawn = false;

        if( currentSpawn <= 4)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (currentSpawn == 3)
                {
                    currentSpawn++;
                   
                }
                Instantiate(Eggs[Random.Range(0, Eggs.Length)], spawnPoint[currentSpawn].transform.position, Quaternion.identity);
                currentSpawn++;
              
            }

            Instantiate(changer, spawnPoint[3].transform.position, Quaternion.identity);
        }  
    }

    private void RandomNumberAssignment()
    {
       
        //still need to figure out how to assign random numbers without repeating 
        
    }
}