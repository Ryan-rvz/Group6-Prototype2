﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
   public void LoadByIndex(int SceneIndex)
   {
        SceneManager.LoadScene(SceneIndex);
        Time.timeScale = 1f;
   }
}
