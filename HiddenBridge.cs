using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenBridge : MonoBehaviour {

    public GameObject Quad;

    public GameObject Port1;
    public GameObject Bridge1_1;
    public GameObject Bridge1_2;

    public GameObject Port2;
    public GameObject Bridge2_1;
    public GameObject Bridge2_2;

    public GameObject Port3;
    public GameObject Bridge3_1;
    public GameObject Bridge3_2;

	public SceneAudioLoader audioLoader;

    private float QuadX, QuadZ;
    private float port1X, port1Z;
    private float port2X, port2Z;
    private float port3X, port3Z;
	    
	// Use this for initialization
	void Start () {
        Bridge1_1.SetActive(false);
        Bridge1_2.SetActive(false);
        Bridge2_1.SetActive(false);
        Bridge2_2.SetActive(false);
        Bridge3_1.SetActive(false);
        Bridge3_2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        QuadX = Mathf.Round(Quad.transform.position.x * 10) / 10;
        QuadZ = Mathf.Round(Quad.transform.position.z * 10) / 10;
        port1X = Mathf.Round(Port1.transform.position.x * 10) / 10;
        port1Z = Mathf.Round(Port1.transform.position.z * 10) / 10;
        port2X = Mathf.Round(Port2.transform.position.x * 10) / 10;
        port2Z = Mathf.Round(Port2.transform.position.z * 10) / 10;
        port3X = Mathf.Round(Port3.transform.position.x * 10) / 10;
        port3Z = Mathf.Round(Port3.transform.position.z * 10) / 10;

        if (QuadX == port1X && QuadZ == port1Z)
        {
			if (Bridge1_1.gameObject.activeSelf == false){
				audioLoader.PlayBridgeSound ();
			}
            Bridge1_1.SetActive(true);
            Bridge1_2.SetActive(true);
        }
        else if (QuadX == port2X && QuadZ == port2Z)
        {
			if (Bridge2_1.gameObject.activeSelf == false){
				audioLoader.PlayBridgeSound ();
			}
			Bridge2_1.SetActive(true);
            Bridge2_2.SetActive(true);
        }
        else if (QuadX == port3X && QuadZ == port3Z)
        {
			if (Bridge3_1.gameObject.activeSelf == false){
				audioLoader.PlayBridgeSound ();
			}
            Bridge3_1.SetActive(true);
            Bridge3_2.SetActive(true);
        }
        
    }
}
