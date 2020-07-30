using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject pauseMenu;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
           else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {

        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void PauseGame()
    {
        
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    void QuitGame()
    {
        //Application.Quit();
    }

    void LoadMenu()
    {
        //just add scene index
        //SceneManager.LoadScene();
    }
}
