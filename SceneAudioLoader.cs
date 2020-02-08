using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneAudioLoader : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip[] audioClips;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> () ;
	}

	public void PlayBridgeSound () {
		Debug.Log ("Bridge sound was played.");
		audioSource.clip = audioClips [0];
		audioSource.Play ();
	}

	public void PlayCoinSound () {
		Debug.Log ("Coin sound was played.");
		audioSource.clip = audioClips [1];
		audioSource.Play ();
	}

	public void PlayGlassSound () {
		Debug.Log ("Glass sound was played.");
		audioSource.clip = audioClips [2];
		audioSource.Play ();
	}

	public void PlayLevelUpSound () {
		Debug.Log ("Level Up sound was played.");
		audioSource.clip = audioClips [3];
		audioSource.Play ();
	}

	public void PlayLoseSound () {
		Debug.Log ("Lose sound was played.");
		audioSource.clip = audioClips [4];
		audioSource.Play ();
	}

	public void PlaySpecialCoinSound () {
		Debug.Log ("Special Coin sound was played.");
		audioSource.clip = audioClips [5];
		audioSource.Play ();
	}

	public void PlayStepSound () {
		Debug.Log ("Step sound was played.");
		audioSource.clip = audioClips [6];
		audioSource.Play ();
	}

	public void PlayTeleportSound () {
		Debug.Log ("Teleport sound was played.");
		audioSource.clip = audioClips [7];
		audioSource.Play ();
	}

}
