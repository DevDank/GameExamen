using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

	public Text scoreText;
	public int score;
	
	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore(0);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(GameIsPaused){
				Resume();
			} else{
				Pause();
			}
			
		}
	}

	void Resume (){
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}


	void Pause (){
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void UpdateScore(int scoreToAdd) {
		score += scoreToAdd;
		scoreText.text= "Score: " + score;
	}
}
