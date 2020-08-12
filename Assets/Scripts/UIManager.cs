using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public Text scoreText;
	int score;
	bool gameOver;
	public Button pauseBttn;
	public Button[] buttons;
	public AudioManager am;
	// Use this for initialization
	void Start () {
		score = 0;
		gameOver = false;
		InvokeRepeating ("UpdateScore", 1.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score : " + score;
	}

	void UpdateScore(){
		if(!gameOver)
			score += 1;
	}

	public void GameOver(){
		gameOver = true;
		pauseBttn.gameObject.SetActive (false);
		foreach (Button button in buttons)
			button.gameObject.SetActive (true);
	}

	public void Pause(){
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
			am.carSound.Stop();
		} else if (Time.timeScale == 0) {
			Time.timeScale = 1;
			am.carSound.Play();
		}
	}

	public void Play(){
		Application.LoadLevel ("Level1");
	}

	public void Menu(){
	}

	public void Exit(){
		Application.Quit ();
	}
}
