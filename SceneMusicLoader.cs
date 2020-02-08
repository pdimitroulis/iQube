using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMusicLoader : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip[] audioClips;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> () ;
		PlayMusic ();
	}

	private void PlayMusic () {
		Debug.Log ("Music started.");
		audioSource.clip = audioClips [0];
		audioSource.Play ();
	}
}
