using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{
    private Player playerScript;
    private SpawnStarter spawnStarterScript;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("PlayerHolder").GetComponent<Player>();
        spawnStarterScript = GameObject.Find("SpawnStarter").GetComponent<SpawnStarter>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PlayerHolder")
        {
            playerScript.ColorSwitch();
            spawnStarterScript.canSpawn = true;
            Destroy(gameObject);
        }
        else if (collision.tag == "ChangerSwitch")
        {
            spawnStarterScript.canSpawn = true;
        }
    }
}
