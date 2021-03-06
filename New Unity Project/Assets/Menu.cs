﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit success");
        Application.Quit();
    }
}

//Code taken and adapted from Youtube video tutorial - Channel: Brackeys https://www.youtube.com/watch?v=zc8ac_qUXQY 
