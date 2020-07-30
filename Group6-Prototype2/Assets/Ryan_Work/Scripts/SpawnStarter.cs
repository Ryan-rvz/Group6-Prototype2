using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStarter : MonoBehaviour
{
    public int eggCount;
    public bool canSpawn;

    private int currentPlayerColor;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision)
        {
            if (collision.tag == "Changer")
            {
                eggCount = 0;
            }
            else if (collision.tag == "Red" || collision.tag == "Green" || collision.tag == "Yellow" || collision.tag == "Blue" || collision.tag == "Black")
            {
                eggCount++;
            }
            if (eggCount == 5)
            {
                eggCount = 0;
                canSpawn = true;
            }

        }
    }
}
