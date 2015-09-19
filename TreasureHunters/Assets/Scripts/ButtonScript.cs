using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
	GameObject startButton;
	GameObject quitButton;
	GameObject creditsButton;
	GameObject backButton;
	GameObject creditsText;
	void Start(){
		startButton = GameObject.Find ("Start Button");
		quitButton = GameObject.Find ("Quit Button");
		creditsButton = GameObject.Find ("Credits Button");
		backButton = GameObject.Find ("Back Button");
		creditsText = GameObject.Find ("Credits Text");
		backButton.SetActive (false);
		creditsText.SetActive (false);
	}

	public void StartGame(){
		Application.LoadLevel (1);
	}

	public void QuitGame(){
		Application.Quit();
	}

	public void ShowCredits(){
		startButton.SetActive (false);
		quitButton.SetActive (false);
		creditsButton.SetActive (false);
		backButton.SetActive (true);
		creditsText.SetActive (true);
	}

	public void ExitCredits(){
		startButton.SetActive (true);
		quitButton.SetActive (true);
		creditsButton.SetActive (true);
		backButton.SetActive (false);
		creditsText.SetActive (false);
	}
}
