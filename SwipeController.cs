using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

//------- This class implements the following functions ----------
// 1. Player's movement
// 2. Hole
// 3. Teleport

public class SwipeController : MonoBehaviour {

	#region variables declaration
	public SwipeInput swipeControls;

	public GameObject Player;

	public GameObject CenterStanding;
	public GameObject RightStanding;
	public GameObject LeftStanding;
	public GameObject UpStanding;
	public GameObject DownStanding;

	public GameObject CenterFallenAxisZ;
	public GameObject RightFallenAxisZ;
	public GameObject LeftFallenAxisZ;
	public GameObject UpFallenAxisZ;
	public GameObject DownFallenAxisZ;

	public GameObject CenterFallenAxisX;
	public GameObject RightFallenAxisX;
	public GameObject LeftFallenAxisX;
	public GameObject UpFallenAxisX;
	public GameObject DownFallenAxisX;

	// Objects for current base 
	private GameObject CenterCurrent;
	private GameObject RightCurrent;
	private GameObject LeftCurrent;
	private GameObject UpCurrent;
	private GameObject DownCurrent;

	public GameObject Quad1; //Two quads on the Player's small seats. Used for Player's orientation.
	public GameObject Quad2;

	public GameObject Hole;

	public int step = 9;
	public float speed = (float)0.01;

	bool input = true;

	private int x1, x2, y1, y2, z1, z2;
	private float holeX, holeZ, playerX, playerZ;

	private int MovesCounter;
	public TextMeshProUGUI MovesText;
	public TextMeshProUGUI LevelText;

	public GameObject TeleportOut;
	public GameObject TeleportIn;

	private float TeleportInX;
	private float TeleportInZ;

	public SceneAudioLoader audioLoader;

	public DataController dataController;
	public PlayerTriggers playerTriggers;
	public GameObject LevelUpWindow;

	private int currLevel;
	#endregion

	private void Start(){
		CenterStanding.transform.position = Player.transform.position;

		CenterCurrent = CenterStanding;
		RightCurrent = RightStanding;
		LeftCurrent = LeftStanding;
		UpCurrent = UpStanding;
		DownCurrent = DownStanding;

		MovesText.text = "Moves : 0";
		currLevel = SceneManager.GetActiveScene ().buildIndex;
		LevelText.text = "Level " + currLevel.ToString ();
	}

	// Update is called once per frame
	private void Update () {
		if (input == true){
			if (swipeControls.SwipeRight){
				StartCoroutine ("moveRight");
				input = false;
			}
			if (swipeControls.SwipeLeft){
				StartCoroutine ("moveLeft");
				input = false;
			}
			if (swipeControls.SwipeUp){
				StartCoroutine ("moveUp");
				input = false;
			}
			if (swipeControls.SwipeDown){
				StartCoroutine ("moveDown");
				input = false;
			}

			if (swipeControls.Tap)
				Debug.Log ("Tap!");
		}
	}

	IEnumerator moveRight() {
		for (int i=0; i<(90/step); i++) {
			Player.transform.RotateAround (RightCurrent.transform.position, Vector3.back, step);
			yield return new WaitForSeconds (speed);
		}
		SetCenter ();
		CenterCurrent.transform.position = Player.transform.position;
		input = true;
	}

	IEnumerator moveLeft() {
		for (int i=0; i<(90/step); i++) {
			Player.transform.RotateAround (LeftCurrent.transform.position, Vector3.forward, step);
			yield return new WaitForSeconds (speed);
		}
		SetCenter ();
		CenterCurrent.transform.position = Player.transform.position;
		input = true;
	}

	IEnumerator moveUp() {
		for (int i=0; i<(90/step); i++) {
			Player.transform.RotateAround (UpCurrent.transform.position, Vector3.right, step);
			yield return new WaitForSeconds (speed);
		}
		SetCenter ();
		CenterCurrent.transform.position = Player.transform.position;
		input = true;
	}

	IEnumerator moveDown() {
		for (int i=0; i<(90/step); i++) {
			Player.transform.RotateAround (DownCurrent.transform.position, Vector3.left, step);
			yield return new WaitForSeconds (speed);
		}
		SetCenter ();
		CenterCurrent.transform.position = Player.transform.position;
		input = true;
	}

	void SetCenter (){
		MovesCounter += 1;
		MovesText.text = "Moves : " + MovesCounter.ToString ();
		audioLoader.PlayStepSound ();

		Teleport ();
		TerminateGame ();

		x1 = Mathf.RoundToInt (Quad1.transform.position.x);
		y1 = Mathf.RoundToInt (Quad1.transform.position.y);
		z1 = Mathf.RoundToInt (Quad1.transform.position.z);
		x2 = Mathf.RoundToInt (Quad2.transform.position.x);
		y2 = Mathf.RoundToInt (Quad2.transform.position.y);
		z2 = Mathf.RoundToInt (Quad2.transform.position.z);

		if (x1 == x2 && z1 == z2) {
			//Player is standing
			CenterCurrent = CenterStanding;
			RightCurrent = RightStanding;
			LeftCurrent = LeftStanding;
			UpCurrent = UpStanding;
			DownCurrent = DownStanding;
		}
		else{
			//Player is fallen
			if (y1 == y2 && z1 == z2) {
				//on axis X 
				CenterCurrent = CenterFallenAxisX;
				RightCurrent = RightFallenAxisX;
				LeftCurrent = LeftFallenAxisX;
				UpCurrent = UpFallenAxisX;
				DownCurrent = DownFallenAxisX;
			}
			else if (x1 == x2 && y1 == y2) {
				//on axis Z
				CenterCurrent = CenterFallenAxisZ;
				RightCurrent = RightFallenAxisZ;
				LeftCurrent = LeftFallenAxisZ;
				UpCurrent = UpFallenAxisZ;
				DownCurrent = DownFallenAxisZ;
			}
			else {
				Debug.Log ("** Problem with Player's Orientation **");
			}
		}

	}

	void TerminateGame() {
		holeX = Mathf.Round (Hole.transform.position.x * 10) / 10; //rounding to one decimal place
		holeZ = Mathf.Round (Hole.transform.position.z * 10) / 10;
		playerX = Mathf.Round (Player.transform.position.x * 10) / 10;
		playerZ = Mathf.Round (Player.transform.position.z * 10) / 10;

		if (holeX == playerX && holeZ == playerZ) {
			audioLoader.PlayLevelUpSound ();
			Player.SetActive (false);
			dataController.UpdateMinMoves (MovesCounter);
			dataController.UpdateTotalCoins (playerTriggers.CoinsCounter);
			PlayerPrefs.SetInt ("LastUnlockedLevel", currLevel + 1);
			LevelUpWindow.gameObject.SetActive (true);
		}
	}

	void Teleport () {
		TeleportInX = Mathf.Round (TeleportIn.transform.position.x * 10) / 10; //rounding to one decimal place
		TeleportInZ = Mathf.Round (TeleportIn.transform.position.z * 10) / 10;
		playerX = Mathf.Round (Player.transform.position.x * 10) / 10;
		playerZ = Mathf.Round (Player.transform.position.z * 10) / 10;

		if (playerX == TeleportInX && playerZ == TeleportInZ) {
			audioLoader.PlayTeleportSound ();
			Player.transform.position = new Vector3(TeleportOut.transform.position.x, Player.transform.position.y, TeleportOut.transform.position.z);
		}
	}
}
