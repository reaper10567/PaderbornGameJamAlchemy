using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
	GameObject creditsText;
	GameObject titleStuff;
	void Start(){
		titleStuff = GameObject.Find ("Title Screen");
		creditsText = GameObject.Find ("Credits Image");
		creditsText.SetActive (false);

	}

	public void StartGame(){
		Application.LoadLevel ("GameScreen");
	}

	public void QuitGame(){
		Application.Quit();
	}

	public void ShowCredits(){
		titleStuff.SetActive (false);
		creditsText.SetActive (true);
	}

	public void ExitCredits(){
		titleStuff.SetActive (true);
		creditsText.SetActive (false);
	}
}
