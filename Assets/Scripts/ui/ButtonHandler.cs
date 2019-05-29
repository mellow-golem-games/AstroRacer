using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour {
	public void startGame() {
		SceneManager.LoadScene("Game");
	}

	public void homeScreen() {
		SceneManager.LoadScene("Start");
	}
}
