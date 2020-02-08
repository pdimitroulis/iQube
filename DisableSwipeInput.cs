using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableSwipeInput : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
		DisableSwipe ();
	}

	public void DisableSwipe () {
		Player.GetComponent<SwipeInput> ().enabled = false;
	}

}
