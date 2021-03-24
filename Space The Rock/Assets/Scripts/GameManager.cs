using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

	public Text scoreText;
	public int score;
	
	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore(0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateScore(int scoreToAdd) {
		score += scoreToAdd;
		scoreText.text= "Score: " + score;
	}
}
