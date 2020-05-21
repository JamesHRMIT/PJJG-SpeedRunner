using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;   // variable updated by DeltaTime, will be used to determine failure conditions
    float startingTime = 20f;  // number of seconds the player begins the level with.
    [SerializeField] Text countdownText;   // Text field that displays the timer.


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;  // initialising the timer with the allocated seconds
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;  // Updates the current time of the level timer each second.
        countdownText.text = currentTime.ToString("0"); // Updates the text object to currentTime.

        if (currentTime <= 10)
        {
            countdownText.color = Color.red;
            countdownText.text = currentTime.ToString("F2");  // Turns timer red and displays milliseconds when under 10 seconds
        }

        if (currentTime <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // resets the current scene when timer hits 0

            //Room here to deduct a life when the timer reaches 0.
        }
    }
}
