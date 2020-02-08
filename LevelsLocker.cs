using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelsLocker : MonoBehaviour {

	public GameObject[] Text1List;  // "Moves" Texts
	public GameObject[] Text2List;  // Moves count Texts
	public GameObject[] LockImgList;
	public GameObject[] ButtonsList;

	private int lastUnlockedLevel;
	private int levelsCount;
	private int tempLevel;

	// Use this for initialization
	void Start () {

		// Update Locks
		lastUnlockedLevel = PlayerPrefs.GetInt ("LastUnlockedLevel", 1);
		// maybe not assigned
		if (lastUnlockedLevel == 1) {
			PlayerPrefs.SetInt ("LastUnlockedLevel", lastUnlockedLevel);
		}
		Debug.Log ("--- LastUnlockedLevel: " + lastUnlockedLevel.ToString ());
		UpdateLocks (lastUnlockedLevel);
		Debug.Log ("--- Locks updated. LastUnlockedLevel: " + lastUnlockedLevel.ToString ());
	}
	
	private void UnlockLevel (int levelNum) {
		Text1List [levelNum - 1].gameObject.SetActive (true);
		Text2List [levelNum - 1].gameObject.SetActive (true);
		LockImgList [levelNum - 1].gameObject.SetActive (false);
		ButtonsList [levelNum - 1].gameObject.GetComponent<Button> ().interactable = true;
	}

	private void LockLevel (int levelNum) {
		Text1List [levelNum - 1].gameObject.SetActive (false);
		Text2List [levelNum - 1].gameObject.SetActive (false);
		LockImgList [levelNum - 1].gameObject.SetActive (true);
		ButtonsList [levelNum - 1].gameObject.GetComponent<Button> ().interactable = false;
	}

	private void UpdateLocks (int lastUnlocked) {
		levelsCount = SceneManager.sceneCountInBuildSettings - 1;

		for (int i = 0; i < levelsCount; i++) {
			tempLevel = i + 1;
			if (tempLevel <= lastUnlocked) {
				UnlockLevel (tempLevel);
			}
			else {
				LockLevel (tempLevel);
			}
		}
	}

}
