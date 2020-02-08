using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour {

	private int minLevelMoves;
	private int currLevel;
	private int totalCoins;
	private int priceCoins;

	public void UpdateMinMoves (int levelMoves) {

		currLevel = SceneManager.GetActiveScene ().buildIndex;
		minLevelMoves = PlayerPrefs.GetInt ("MovesL" + currLevel.ToString ());

		if (levelMoves < minLevelMoves) {
			PlayerPrefs.SetInt ("MovesL"+ currLevel.ToString (), levelMoves);
		}
	}

	public void UpdateTotalCoins (int levelCoins) {
		currLevel = SceneManager.GetActiveScene ().buildIndex;
		totalCoins = PlayerPrefs.GetInt ("TotalCoins");
		PlayerPrefs.SetInt ("TotalCoins", totalCoins + levelCoins);
	}

	public void DecreaseTotalCoins () {
		priceCoins = 2;

		totalCoins = PlayerPrefs.GetInt ("TotalCoins");
		if (totalCoins - priceCoins >=0 ){
			PlayerPrefs.SetInt ("TotalCoins", totalCoins - priceCoins);
		}
		else {
			Debug.Log ("***More collected coins are required***");
		}
	}

}
