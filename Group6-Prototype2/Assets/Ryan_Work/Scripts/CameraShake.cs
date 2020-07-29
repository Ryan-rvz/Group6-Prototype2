using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    public float Shakeduration, Shakemagnitude;
    


  

    public IEnumerator screenShake(float duration, float magnitude)
    {
        Vector3 currentPos = transform.localPosition;
        float elapsed = 0f;


        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, currentPos.z);

            elapsed += Time.deltaTime;
            

            yield return null;

        }

        transform.localPosition = currentPos;
        
    }

    public void WrongEggShake()
    {
        StartCoroutine(screenShake(Shakeduration, Shakemagnitude));
    }

  
}
