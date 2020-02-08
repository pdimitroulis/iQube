using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

//------- This class implements the following functions -------
// 1. antifloor
// 2. coin 
// 3. special coin

public class PlayerTriggers : MonoBehaviour {

	public TextMeshProUGUI CoinsText;
	public GameObject Coins;
	public SceneAudioLoader audioLoader;
	public GameplayButtons gameplayButtons;

	public int CoinsCounter;

	// Use this for initialization
	void Start () {
		CoinsCounter = 0;
		CoinsText.text = "Coins : 0";
		if(SceneManager.GetActiveScene ().buildIndex != 1 && SceneManager.GetActiveScene ().buildIndex != 3){ //Level1, Level3 don't include special coin
			Coins.gameObject.SetActive (false);
		}
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.CompareTag ("Antifloor")){
			// Falling
			audioLoader.PlayLoseSound ();
			this.gameObject.SetActive (false);
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name); //Reload scene
		}
		else if (other.gameObject.CompareTag ("Coin")){
			// Earn coin
			audioLoader.PlayCoinSound ();
			other.gameObject.SetActive (false);
			gameplayButtons.UpdateHelpButton ();
			CoinsCounter += 1;
			CoinsText.text = "Coins : " + CoinsCounter.ToString ();
		}
		else if (other.gameObject.CompareTag ("Special Coin")){
			// Earn special coin
			audioLoader.PlaySpecialCoinSound ();
			other.gameObject.SetActive (false);
			Coins.gameObject.SetActive (true);
		}
	}
}
