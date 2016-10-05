using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int min, max, guess;
	int maxGuessesAllowed = 10;
	public Text guessNum;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame(){
		min = 1;
		max = 1000;
		guess = 500;
		max = max + 1;
	}

	void NextGuess() {
		guess = (max + min) / 2;
		guessNum.text = guess.ToString ();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}

	public void GuessLower(){
		max = guess;
		NextGuess ();
	}

	public void GuessHigher(){
		min = guess;
		NextGuess ();
	}
}
