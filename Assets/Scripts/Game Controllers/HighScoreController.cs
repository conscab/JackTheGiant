﻿using UnityEngine;
using System.Collections;

public class HighScoreController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
public void GoBackToMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }
}
