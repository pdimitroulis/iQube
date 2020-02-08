using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

// This script implements data loading on LevelsMenu and data initialization. 
// It's attached to Main Panel of Menu.scene

public class DataLoader : MonoBehaviour {

	public TextMeshProUGUI[] MovesTextsForLevels; // e.g. "23", "11"
	public TextMeshProUGUI TotalCoinsText; // e.g. "Total Coins: 21"

	private int LevelsCount;
	private int[] MovesForLevels; // e.g. 23, 11
	private int MaxPossibleMoves;

	public TextMeshProUGUI score;

	// Use this for initialization
	void Start () {
		LevelsCount = MovesTextsForLevels.Length;
//		Debug.Log ("LevelsCount: "+LevelsCount.ToString ());

		MovesForLevels = new int[LevelsCount];
		MaxPossibleMoves = 10000;

		//Update Moves and initialize prefs for each level
		for (int i = 0; i < LevelsCount; i++) {
			MovesForLevels [i] = PlayerPrefs.GetInt ("MovesL" + (i + 1).ToString (), MaxPossibleMoves);
			PlayerPrefs.SetInt ("MovesL" + (i + 1).ToString (), MovesForLevels[i]);
		}

		//Update texts for each level
		for (int i = 0; i < LevelsCount; i++) {
			if (MovesForLevels[i] == MaxPossibleMoves) {
				MovesTextsForLevels[i].text = "-";	
			}
			else {
				MovesTextsForLevels [i].text = MovesForLevels[i].ToString ();
			}
		}

		TotalCoinsText.text = "Total Coins: " + PlayerPrefs.GetInt ("TotalCoins", 0).ToString ();

	}
		
	// Clear all Player's data
	public void ResetAllPlayerPrefs () {
		PlayerPrefs.DeleteAll ();
		for (int i = 0; i < 5; i++) {
			MovesTextsForLevels [i].text = "-";
			MovesForLevels [i] = MaxPossibleMoves;
			TotalCoinsText.text = "Total Coins: 0";
		}
		Start ();
		Debug.Log ("All PlayerPrefs are deleted.");
	}

}
