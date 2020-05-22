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


// Some code taken and adapted from a Youtube video tutorial, 
// sections are: variables, void start method and void update method (increment with Delta Time and countdownText ToString
//Both if statements are origional code
//answers on scene manager found in unity forums https://answers.unity.com/questions/1406791/how-to-restart-level-when-timer-reaches-0.html
//youtube channel: Single Sapling Games https://www.youtube.com/watch?v=o0j7PdU88a4
