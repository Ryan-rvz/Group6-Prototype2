using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStarterMove : MonoBehaviour
{
    public GameObject targetPosition;
    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {

       if(transform.position != targetPosition.transform.position)
        {
            transform.position = Vector3.MoveTowards(this.transform.position, targetPosition.transform.position, moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = targetPosition.transform.position;
        }
    }
}
