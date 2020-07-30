using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalVarHolder : MonoBehaviour
{
   
    public float currentSpeed;
    public float maxSpeed;

    public int score;

    public float accelerationTime;
    private float minSpeed;
    private float time;

    public float currentTime;
    public float timeDecreaseSpeed;

    private CameraShake screenShake;
    private GameObject playerHolder;

    public float slowingSpeed;

    [HideInInspector]
    public static bool playerDead;

    private SoundManager soundScript;
    

    private void Awake()
    {
        playerDead = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        soundScript = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
        screenShake = GameObject.Find("MainCamera").GetComponent<CameraShake>();
        playerHolder = GameObject.Find("PlayerHolder");
        minSpeed = currentSpeed;
        time = 0;      
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed = Mathf.SmoothStep(minSpeed, maxSpeed, time / accelerationTime);
        time += Time.deltaTime;
        currentTime = Time.timeScale;

        if (playerDead)
        {
            Time.timeScale -= Time.deltaTime * timeDecreaseSpeed;
        }
        

    }
 

    public void AddToScore()
    {
        score++;
    }

    public void PlayerDeath()
    {
        soundScript.DeathSound();
        playerDead = true;    
        screenShake.WrongEggShake();
        Destroy(playerHolder);
    }
}
