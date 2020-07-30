using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public Text scoreText;

    public GameObject gameOverMenu;

    private void Awake()
    {
        playerDead = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu.SetActive(false);

        soundScript = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
        screenShake = GameObject.Find("MainCamera").GetComponent<CameraShake>();
        playerHolder = GameObject.Find("PlayerHolder");
        minSpeed = currentSpeed;
        time = 0;      
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;

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
        gameOverMenu.SetActive(true);
        screenShake.WrongEggShake();
        Destroy(playerHolder);
    }
}
