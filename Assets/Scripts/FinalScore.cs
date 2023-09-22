using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    TMP_Text finalScore;
    // Start is called before the first frame update
    void Start()
    {
        
        finalScore = GetComponent<TMP_Text>();
        if(ScoreTracker.score > ScoreTracker.highScore ) {
            ScoreTracker.highScore = ScoreTracker.score;
        }
        finalScore.SetText($"High Score: {ScoreTracker.highScore}");


    }


}
