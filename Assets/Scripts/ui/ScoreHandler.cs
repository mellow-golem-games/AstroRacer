﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{

    public Text HighScore;
    public int score;

    // Start is called before the first frame update
    void Start() {
      HighScore.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update() {
      // score++; // TODO remove we're doing a more "complex" score calc
      HighScore.text = "Score: " + score;
    }

    void OnDestroy() {
      // handles checking and updating score
      PlayerPrefs.SetInt("currentScore", this.score); // set the current score first
      int currentScore = PlayerPrefs.GetInt("score", 0);

      if(score > currentScore) {
        PlayerPrefs.SetInt("score", this.score);
      }
    }

    public void updateScore(int amount) {
      score += amount;
    }
}
