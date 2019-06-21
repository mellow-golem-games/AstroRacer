using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour {
	public void startGame() {
		SceneManager.LoadScene("Game");
	}

	public void startGameOnShip() {
		// check if the user has the current ship unlocked
		SceneManager.LoadScene("Game");
	}

	public void homeScreen() {
		SceneManager.LoadScene("Start");
	}

	public void handleBackShipButton() {
		GameObject ShipSwitcher = GameObject.Find("ShipSwitcher");
		ShipSwitcher buttonScript = (ShipSwitcher) ShipSwitcher.GetComponent(typeof(ShipSwitcher));
		buttonScript.switchShip("back");
	}

	public void handleForwardShipButton() {
		GameObject ShipSwitcher = GameObject.Find("ShipSwitcher");
		ShipSwitcher buttonScript = (ShipSwitcher) ShipSwitcher.GetComponent(typeof(ShipSwitcher));
		buttonScript.switchShip("up");
	}

}
