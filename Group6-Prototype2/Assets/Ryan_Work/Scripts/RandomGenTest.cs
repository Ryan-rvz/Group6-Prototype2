using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenTest : MonoBehaviour
{
    public int rand;
    public int length = 5;
    public List<int> randomList = new List<int>();

    void Start()
    {
        

    
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            GenerateList();
        }
        
    }

    public void GenerateList()
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
            print(randomList[j]);
        }
    }
}
