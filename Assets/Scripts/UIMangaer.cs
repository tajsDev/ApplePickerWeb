using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;


public class UIMangaer : MonoBehaviour
{
    void Awake() {
        Application.targetFrameRate = 60;

    }
    public void restart() {
        ScoreTracker.score = 0;
        SceneManager.LoadScene("Intro");
    }
    public void easyMode() {
        ScoreTracker.numOfLives = 5;
        ScoreTracker.spawnGreenApples = false;
        ScoreTracker.spawnBlackApples = false;
        ScoreTracker.appleDropDelay = 2f;
        SceneManager.LoadScene("ApplePicket");
    }

    public void mediumMode() {
        ScoreTracker.numOfLives = 4;
        ScoreTracker.spawnGreenApples = true;
        ScoreTracker.spawnBlackApples = false;
        ScoreTracker.appleDropDelay = 1f;
        SceneManager.LoadScene("ApplePicket");
    }

    public void hardMode() {
        ScoreTracker.numOfLives = 3;
        ScoreTracker.spawnGreenApples = true;
        ScoreTracker.spawnBlackApples = true;
        ScoreTracker.appleDropDelay = 0.75f;
        SceneManager.LoadScene("ApplePicket");
    }
}
