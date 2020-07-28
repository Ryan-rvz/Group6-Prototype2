using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{
    private Player playerScript;
    private SpawnStarter spawnStaterScript;
    

    private void Start()
    {
        playerScript = GameObject.Find("PlayerHolder").GetComponent<Player>();
        spawnStaterScript = GameObject.Find("SpawnStarter").GetComponent<SpawnStarter>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.name == "PlayerHolder")
        {
            playerScript.ColorSwitch();
            spawnStaterScript.canSpawn = true;
      
        }
    }

    private void Update()
    {
     
    }

}
