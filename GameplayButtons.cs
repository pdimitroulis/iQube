using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayButtons : MonoBehaviour {

	public GameObject UIButtons;
	public AudioSource audioSource;
	public AudioSource musicSource;
    private Solutions objSol;
	private int currScene;
	private int lastScene;
	private int totalCoins;
	private int priceCoins;

	private Button helpButton;
    // Use this for initialization
    void Start () {
		lastScene = SceneManager.sceneCountInBuildSettings - 1;
		Debug.Log ("lastScene: " + lastScene.ToString ());

		objSol = GameObject.FindObjectOfType(typeof(Solutions)) as Solutions;
        UIButtons.transform.Find ("ReplayButton").gameObject.SetActive (true);
		UIButtons.transform.Find ("MuteButton").gameObject.SetActive (true);
		UIButtons.transform.Find ("MenuButton").gameObject.SetActive (true);

		UpdateHelpButton ();
	}
	
	public void Replay (){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void Mute (){
		Debug.Log ("--Mute--");
		audioSource.mute = !audioSource.mute;
		musicSource.mute = !musicSource.mute;
	}

	public void BackToMenu () {
		if (Application.CanStreamedLevelBeLoaded ("Menu")){
			SceneManager.LoadScene ("Menu");
		}
		else {
			Debug.Log ("*There's no such scene name. Scene 0 is loading.");
			SceneManager.LoadScene (0);
		}
	}

	public void LoadNextLevel () {
		currScene = SceneManager.GetActiveScene ().buildIndex;
		Debug.Log ("currScene: " + currScene.ToString ());
		Debug.Log ("lastScene: " + lastScene.ToString ());
		if (currScene == lastScene) {
			SceneManager.LoadScene (0); //Load Menu
		}
		else {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1); //Load next scene
		}
	}

    public void ShowLevelSolution() {
        print(SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().name == "Level1") {
            objSol.Level1Solution();
        }
        else if (SceneManager.GetActiveScene().name == "Level2_specialCoin")
        {
            objSol.Level2Solution();
        }
        else if (SceneManager.GetActiveScene().name == "Level3_glass")
        {
            objSol.Level3Solution();
        }
        else if (SceneManager.GetActiveScene().name == "Level4_teleport")
        {
            objSol.Level4Solution();
        }
        else if (SceneManager.GetActiveScene().name == "Level5")
        {
            objSol.Level5Solution();
        }
    }
    
	public void UpdateHelpButton () {
		priceCoins = 2; // --OPTION 
		totalCoins = PlayerPrefs.GetInt ("TotalCoins");
		helpButton = GameObject.Find ("HelpButton").GetComponent<Button> ();
		helpButton.gameObject.SetActive (true);
		if (totalCoins >= priceCoins) {
			helpButton.interactable = true;
		}
		else {
			helpButton.interactable = false;
		}
	}
}
