using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteToColorBunny : MonoBehaviour
{
    public SpriteRenderer spriteRend;

    private Color oG;
    public Color white;
    public SpawnStarter spawnStater;
    private bool firstTime;

    private Player playerScript;

    private void Awake()
    {
        oG = spriteRend.color;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerScript = this.gameObject.GetComponent<Player>();
        firstTime = true;
        spriteRend.color = white;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Changer" && firstTime)
        {
            firstTime = false;          
            spawnStater.canSpawn = true;
            spriteRend.color = oG;
        }
        else if (collision.tag == "First")
        {
            firstTime = false;
            spawnStater.canSpawn = true;
            spriteRend.color = oG;
        }

    }
}
