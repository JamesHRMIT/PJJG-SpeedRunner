using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text score;
    private int ScoreCOUNT = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + ScoreCOUNT; ;
    }

    public void changeScore(int ScoreUpdate) {
        ScoreCOUNT = ScoreCOUNT + ScoreUpdate;

    }
}
