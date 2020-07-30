using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerColorSwitching : MonoBehaviour
{
    private SpriteRenderer spriteRend;

    public Color red;
    public Color purple;
    public Color yellow;
    public Color blue;

    public float flashTime;

    // Start is called before the first frame update
    void Start()
    {
        spriteRend = this.gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine(ColorChange());
        
    }

   IEnumerator ColorChange()
    {
        spriteRend.color = red;
        yield return new WaitForSeconds(flashTime);
        spriteRend.color = yellow;
        yield return new WaitForSeconds(flashTime);
        spriteRend.color = blue;
        yield return new WaitForSeconds(flashTime);
        spriteRend.color = purple;
        yield return new WaitForSeconds(flashTime);

        StartCoroutine(ColorChange());
    }
}
