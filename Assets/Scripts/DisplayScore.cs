using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    TMP_Text appleScore;
    public TMP_Text lives;
    // Start is called before the first frame update
    void Start()
    {
        
        appleScore = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        appleScore.SetText($"Score: {ScoreTracker.score}");
        lives.SetText($"Lives: {ScoreTracker.numOfLives}");
        
    }
}
