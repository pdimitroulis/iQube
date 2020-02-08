using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Glass : MonoBehaviour {

    public GameObject Player;
    public GameObject Quad;

    public GameObject Glass1, Glass2;

	public SceneAudioLoader audioLoader;

    private float QuadX, QuadZ;
    private float glass1X, glass1Z;
    private float glass2X, glass2Z;

	// Update is called once per frame
	void Update () {
        QuadX = Mathf.Round(Quad.transform.position.x * 10) / 10;
        QuadZ = Mathf.Round(Quad.transform.position.z * 10) / 10;
        glass1X = Mathf.Round(Glass1.transform.position.x * 10) / 10;
        glass1Z = Mathf.Round(Glass1.transform.position.z * 10) / 10;
        glass2X = Mathf.Round(Glass2.transform.position.x * 10) / 10;
        glass2Z = Mathf.Round(Glass2.transform.position.z * 10) / 10;

        if (glass1X == QuadX && glass1Z == QuadZ)
        {
			audioLoader.PlayGlassSound ();
            Player.SetActive(false);
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name); // Reload scene
        }
        else if (glass2X == QuadX && glass2Z == QuadZ)
        {
			audioLoader.PlayGlassSound ();
            Player.SetActive(false);
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name); // Reload scene
        }
    }
}
