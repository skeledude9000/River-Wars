using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerStartButtons : MonoBehaviour {

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
		TowerMenuStart.AssTroidS = 0;
	}
	public void Settings(string scenename){
		Application.LoadLevel(scenename);
	}
}
