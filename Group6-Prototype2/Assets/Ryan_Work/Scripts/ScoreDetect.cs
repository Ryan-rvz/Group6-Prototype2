using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDetect : MonoBehaviour
{
    public UniversalVarHolder universeScript;

    private void Start()
    {
        universeScript = GameObject.Find("UniversalManager").GetComponent<UniversalVarHolder>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision)
        {
            universeScript.AddToScore();
        }
    }
}
