using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private UniversalVarHolder universeScript;

    // Start is called before the first frame update
    void Start()
    {
        universeScript = GameObject.Find("UniversalManager").GetComponent<UniversalVarHolder>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * universeScript.currentSpeed * Time.deltaTime;
    }
}
