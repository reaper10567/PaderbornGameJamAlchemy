﻿using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	public void StartGame(){
		Application.LoadLevel (1);
	}

	public void QuitGame(){
		Application.Quit();
	}

	public void ShowCredits(){
	}
}
