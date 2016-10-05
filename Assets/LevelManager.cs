using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	//Load a new level
	public void LoadLevel(string name){
		Debug.Log ("Fuckin' " + name);
		Application.LoadLevel (name);
	}

	//Quit the game
	public void QuitRequest(){
		Debug.Log ("GET THE FUCK OUT THEN!");
		//Only use on Consoles and Computers!
		//Not on phones,web, or debug!!
		Application.Quit ();
	}

}
