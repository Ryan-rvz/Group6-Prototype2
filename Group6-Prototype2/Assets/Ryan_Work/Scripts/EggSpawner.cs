using System.Collections;
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
    private int index1, index2, index3, index4;
    public int rand;
    public int length = 5;
    public List<int> randomList = new List<int>();

    private void Awake()
    {
        RandomNumberAssignment();

    }

    private void Start()
    {
        spawnStarter.canSpawn = true;
        patternToSpawn = 0;


    }

    private void Update()
    {
     


      if (spawnStarter.canSpawn)
        {
            patternToSpawn = Random.Range(0, 11);

         
            if (patternToSpawn == 0)
            {
                RandomNumberAssignment();
                StraightLine1();
            }

            if (patternToSpawn == 1)
            {
                RandomNumberAssignment();
                StraightLine2();
            }

            if (patternToSpawn == 2)
            {
                ZigZag1();
            }

            if (patternToSpawn == 3)
            {
                ZigZag3();
            }

           if (patternToSpawn == 4 && Time.time >= timeChanger)
           {
               timeChanger = Time.time + timeBetweenChanger;
                ChangerStraight1();
           }
           if (patternToSpawn == 5)
            {
                RandomNumberAssignment();
                TwoOneTwo1();
            }
           if (patternToSpawn == 6)
            {
                RandomNumberAssignment();
                TwoOneTwo2();
            }
           if (patternToSpawn == 7)
            {
                RandomNumberAssignment();
                OneOneOne1();
            }
           if(patternToSpawn == 8)
            {
                RandomNumberAssignment();
                OneOneOne2();
            }

           if (patternToSpawn == 9)
            {
                ZigZag2();
            }

           if (patternToSpawn == 10)
            {
                ZigZag4();
            }
           else
           {
              patternToSpawn = Random.Range(0, 11);
           }

        }

    }


    
    public void StraightLine1()
    {
        spawnStarter.canSpawn = false;
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], spawnPoint[0].transform.position, Quaternion.identity);
        Instantiate(Eggs[Player.currentColor], spawnPoint[index1].transform.position, Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], spawnPoint[index2].transform.position, Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], spawnPoint[index3].transform.position, Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)],spawnPoint[index4].transform.position, Quaternion.identity);
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
            Instantiate(Eggs[randomColorIndex], spawnPoint[index1].transform.position, Quaternion.identity);
            Instantiate(Eggs[randomColorIndex], spawnPoint[index2].transform.position, Quaternion.identity);
            Instantiate(Eggs[Player.currentColor], spawnPoint[index3].transform.position, Quaternion.identity);
            Instantiate(Eggs[randomColorIndex], spawnPoint[index4].transform.position, Quaternion.identity);
        }
        
    }

    //dont apply random modifier here
    public void ZigZag1()

    {
        spawnStarter.canSpawn = false;
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[0].transform.position.x, spawnPoint[0].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Player.currentColor], new Vector2(spawnPoint[1].transform.position.x + 1.5f, spawnPoint[1].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[2].transform.position.x + 3f, spawnPoint[2].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[3].transform.position.x + 4.5f, spawnPoint[3].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[4].transform.position.x + 6f, spawnPoint[4].transform.position.y), Quaternion.identity);

    }

    public void ZigZag2()
    {
        spawnStarter.canSpawn = false;
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[0].transform.position.x, spawnPoint[0].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[1].transform.position.x + 1.5f, spawnPoint[1].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[2].transform.position.x + 3f, spawnPoint[2].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[3].transform.position.x + 4.5f, spawnPoint[3].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Player.currentColor], new Vector2(spawnPoint[4].transform.position.x + 6f, spawnPoint[4].transform.position.y), Quaternion.identity);
    }

    public void ZigZag3()
    {
        spawnStarter.canSpawn = false;
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[0].transform.position.x + 6f, spawnPoint[0].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[1].transform.position.x + 4.5f, spawnPoint[1].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Player.currentColor], new Vector2(spawnPoint[2].transform.position.x + 3f, spawnPoint[2].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[3].transform.position.x + 1.5f, spawnPoint[3].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[4].transform.position.x, spawnPoint[4].transform.position.y), Quaternion.identity);
    }

    public void ZigZag4()
    {
        spawnStarter.canSpawn = false;
        Instantiate(Eggs[Player.currentColor], new Vector2(spawnPoint[0].transform.position.x + 6f, spawnPoint[0].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[1].transform.position.x + 4.5f, spawnPoint[1].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[2].transform.position.x + 3f, spawnPoint[2].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[3].transform.position.x + 1.5f, spawnPoint[3].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[4].transform.position.x, spawnPoint[4].transform.position.y), Quaternion.identity);
    }


    public void TwoOneTwo1()
    {
        spawnStarter.canSpawn = false;
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[0].transform.position.x, spawnPoint[0].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Player.currentColor], new Vector2(spawnPoint[index1].transform.position.x, spawnPoint[index1].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[index2].transform.position.x + 1.5f, spawnPoint[index2].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[index3].transform.position.x, spawnPoint[index3].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[index4].transform.position.x, spawnPoint[index4].transform.position.y), Quaternion.identity);
    }
    public void TwoOneTwo2()
    {
        spawnStarter.canSpawn = false;
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[0].transform.position.x, spawnPoint[0].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Player.currentColor], new Vector2(spawnPoint[index1].transform.position.x, spawnPoint[index1].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[index2].transform.position.x - 1.5f, spawnPoint[index2].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[index3].transform.position.x, spawnPoint[index3].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[index4].transform.position.x, spawnPoint[index4].transform.position.y), Quaternion.identity);
    }

    public void OneOneOne1()
    {
        spawnStarter.canSpawn = false;
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[0].transform.position.x, spawnPoint[0].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Player.currentColor], new Vector2(spawnPoint[index1].transform.position.x + 1.5f, spawnPoint[index1].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[index2].transform.position.x , spawnPoint[index2].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[index3].transform.position.x + 1.5f, spawnPoint[index3].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[index4].transform.position.x, spawnPoint[index4].transform.position.y), Quaternion.identity);
    }
    public void OneOneOne2()
    {
        spawnStarter.canSpawn = false;
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[0].transform.position.x, spawnPoint[0].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Player.currentColor], new Vector2(spawnPoint[index1].transform.position.x - 1.5f, spawnPoint[index1].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[index2].transform.position.x, spawnPoint[index2].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[index3].transform.position.x - 1.5f, spawnPoint[index3].transform.position.y), Quaternion.identity);
        Instantiate(Eggs[Random.Range(0, Eggs.Length)], new Vector2(spawnPoint[index4].transform.position.x, spawnPoint[index4].transform.position.y), Quaternion.identity);
    }


    public void ChangerStraight1()
    {
        spawnStarter.canSpawn = false;
        Instantiate(Eggs[4], spawnPoint[0].transform.position, Quaternion.identity);
        Instantiate(Eggs[4], spawnPoint[index1].transform.position, Quaternion.identity);
        Instantiate(Eggs[4], spawnPoint[index2].transform.position, Quaternion.identity);
        Instantiate(changer, spawnPoint[index3].transform.position, Quaternion.identity);
        Instantiate(Eggs[4], spawnPoint[index4].transform.position, Quaternion.identity);
    }

    

    private void RandomNumberAssignment()
    {

        randomList = new List<int>(new int[length]);

        for (int j = 1; j < length; j++)
        {
            rand = Random.Range(0, 5);

            while (randomList.Contains(rand))
            {
                rand = Random.Range(0, 5);
            }

            randomList[j] = rand;     

        }
        index1 = randomList[1];
        index2 = randomList[2];
        index3 = randomList[3];
        index4 = randomList[4];

    }
}
