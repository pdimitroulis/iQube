using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableSwipeInput : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
		EnableSwipe ();
	}

	public void EnableSwipe () {
		Player.GetComponent<SwipeInput> ().enabled = true;
	}

}
