using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour {

	
	public Text scoreText;
	public int score;
	public GameObject GameOverScreen;
	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	public List<GameObject> astroids;
	
	public GameObject ShittySpawnPoint;
	public float spawnRate = 1.0f;
	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore(0);
		
		StartGame();
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


	public void GameOver(){
	GameOverScreen.SetActive(true);

	} 


	IEnumerator SpawnTarget()
    {
        while (GameIsPaused == false)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, astroids.Count);
            Instantiate(astroids[index], ShittySpawnPoint.transform.position, ShittySpawnPoint.transform.rotation);

            
        }
       
    }

	public void StartGame()
    {       
        StartCoroutine(SpawnTarget());
    }


	
}

