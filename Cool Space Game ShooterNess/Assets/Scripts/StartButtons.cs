using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtons : MonoBehaviour {

	void Start(){
		PlayerPrefs.SetInt ("TowerD", 0);
	}

	void TowerStart(){
		PlayerPrefs.SetInt("TowerD", 1);
	}

	public void changemenuscene(string scenename){
		Application.LoadLevel(scenename);
	}

	public void Quit(){
		Application.Quit();
	}

	void ResetScore(){
		MenuStart.Plr1S = 0;
		MenuStart.Plr2S = 0;
		PlayerPrefs.DeleteAll ();
	}
	public void Settings(string scenename){
		Application.LoadLevel(scenename);
	}
	public void Credits(string scenename){
		Application.LoadLevel(scenename);
	}
}
