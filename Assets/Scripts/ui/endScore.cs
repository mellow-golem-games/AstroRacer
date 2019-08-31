using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScore : MonoBehaviour
{
    public Text Score;
    // Start is called before the first frame update
    void Start() {
      int currentScore = PlayerPrefs.GetInt("currentScore", 0);
      int currentHighscore = PlayerPrefs.GetInt("score", 0);
      Score.text = "Final Score: " + currentScore;


  		if(currentHighscore == currentScore) {
  			Score.text += "\n New High Score!: " + currentHighscore;
  		} else {
  			Score.text += "\n High Score: " + currentHighscore;
  		}
    }
}
