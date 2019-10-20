using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	

    public void StartGame()
    {
        Application.LoadLevel("Gameplay");
    }


    public void HighscoresMenu()
    {
        Application.LoadLevel("HighScore");
    }

    public void OptionsMenu()
    {
        Application.LoadLevel("OptionsMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    

    public void MusicButton()
    {

    }
}
