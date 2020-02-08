using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Solutions : MonoBehaviour {
    struct MoveSol {
        public GameObject first;
        public GameObject sec;
        public bool isOne;

        public MoveSol (GameObject a1, GameObject a2, bool a3)
        {
            first = a1;
            sec = a2;
            isOne = a3;
        }
    }

	public GameplayButtons gameplayButtons;
	public GameObject helpButton;
    public GameObject move1_1;
    public GameObject move1_2;
    public GameObject move2_1;
    public GameObject move2_2;
    public GameObject move3_1;
    public GameObject move3_2;
    public GameObject move4_1;
    public GameObject move4_2;
    public GameObject move5_1;
    public GameObject move5_2;
    public GameObject move6_1;
    public GameObject move6_2;
    public GameObject move7_1;
    public GameObject move7_2;
    public GameObject move8_1;
    public GameObject move8_2;
    public GameObject move9_1;
    public GameObject move9_2;
    public GameObject move10_1;
    public GameObject move10_2;
    public GameObject move11_1;
    public GameObject move11_2;
    public GameObject move12_1;
    public GameObject move12_2;
    public GameObject move13_1;
    public GameObject move13_2;
    public GameObject move14_1;
    public GameObject move14_2;
    public GameObject move15_1;
    public GameObject move15_2;
    public GameObject move16_1;
    public GameObject move16_2;
    public GameObject move17_1;
    public GameObject move17_2;
    public GameObject move18_1;
    public GameObject move18_2;
    public GameObject move19_1;
    public GameObject move19_2;
    public GameObject move20_1;
    public GameObject move20_2;
    public GameObject move21_1;
    public GameObject move21_2;
    public GameObject move22_1;
    public GameObject move22_2;
    public GameObject move23_1;
    public GameObject move23_2;
    public GameObject move24_1;
    public GameObject move24_2;
    public GameObject move25_1;
    public GameObject move25_2;
    public GameObject move26_1;
    public GameObject move26_2;
    public GameObject move27_1;
    public GameObject move27_2;
    public GameObject move28_1;
    public GameObject move28_2;
    public GameObject move29_1;
    public GameObject move29_2;
    public GameObject move30_1;
    public GameObject move30_2;
    public GameObject move31_1;
    public GameObject move31_2;
    
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void Level1Solution()
    {
        // create a solution cube list for level 1
        MoveSol[] list = {
            new MoveSol(move1_1, move1_2, false),
            new MoveSol(move2_1, move2_2, true),
            new MoveSol(move3_1, move3_2, false),
            new MoveSol(move4_1, move4_2, true),
            new MoveSol(move5_1, move5_2, false),
            new MoveSol(move6_1, move6_2, false),
            new MoveSol(move7_1, move7_2, true),
            new MoveSol(move8_1, move8_2, false),
            new MoveSol(move9_1, move9_2, true),
            new MoveSol(move10_1, move10_2, false),
            new MoveSol(move11_1, move11_2, true),
            new MoveSol(move12_1, move12_2, false),
            new MoveSol(move13_1, move13_2, true),
            new MoveSol(move14_1, move14_2, false),
            new MoveSol(move15_1, move15_2, false),
            new MoveSol(move16_1, move16_2, true),
            new MoveSol(move17_1, move17_2, false),
            new MoveSol(move18_1, move18_2, false),
            new MoveSol(move19_1, move19_2, true)
        };
        
        StartCoroutine(GetSolution(list));
        
    }

    public void Level2Solution()
    {
        // create a solution cube list for level 1
        MoveSol[] list = {
            new MoveSol(move1_1, move1_2, false),
            new MoveSol(move2_1, move2_2, true),
            new MoveSol(move3_1, move3_2, true),
            new MoveSol(move4_1, move4_2, false),
            new MoveSol(move5_1, move5_2, true),
            new MoveSol(move6_1, move6_2, false),
            new MoveSol(move7_1, move7_2, false),
            new MoveSol(move8_1, move8_2, true),
            new MoveSol(move9_1, move9_2, false),
            new MoveSol(move10_1, move10_2, false),
            new MoveSol(move11_1, move11_2, false),
            new MoveSol(move12_1, move12_2, true),
            new MoveSol(move13_1, move13_2, false),
            new MoveSol(move14_1, move14_2, true),
            new MoveSol(move15_1, move15_2, false),
            new MoveSol(move16_1, move16_2, true),
            new MoveSol(move17_1, move17_2, false),
            new MoveSol(move18_1, move18_2, false),
            new MoveSol(move19_1, move19_2, true)
        };
        
        StartCoroutine(GetSolution(list));
        
    }

    public void Level3Solution()
    {
        // create a solution cube list for level 1
        MoveSol[] list = {
            new MoveSol(move1_1, move1_2, false),
            new MoveSol(move2_1, move2_2, true),
            new MoveSol(move3_1, move3_2, false),
            new MoveSol(move4_1, move4_2, true),
            new MoveSol(move5_1, move5_2, false),
            new MoveSol(move6_1, move6_2, false),
            new MoveSol(move7_1, move7_2, true),
            new MoveSol(move8_1, move8_2, false),
            new MoveSol(move9_1, move9_2, false),
            new MoveSol(move10_1, move10_2, true),
            new MoveSol(move11_1, move11_2, false),
            new MoveSol(move12_1, move12_2, false),
            new MoveSol(move13_1, move13_2, true),
            new MoveSol(move14_1, move14_2, false),
            new MoveSol(move15_1, move15_2, false),
            new MoveSol(move16_1, move16_2, true),
            new MoveSol(move17_1, move17_2, false),
            new MoveSol(move18_1, move18_2, true),
            new MoveSol(move19_1, move19_2, false),
            new MoveSol(move20_1, move20_2, true),
            new MoveSol(move21_1, move21_2, false),
            new MoveSol(move22_1, move22_2, true),
            new MoveSol(move23_1, move23_2, false),
            new MoveSol(move24_1, move24_2, false),
            new MoveSol(move25_1, move25_2, true)
        };
        
        StartCoroutine(GetSolution(list));
        
    }


    public void Level4Solution()
    {
        // create a solution cube list for level 1
        MoveSol[] list = {
            new MoveSol(move1_1, move1_2, false),
            new MoveSol(move2_1, move2_2, false),
            new MoveSol(move3_1, move3_2, true),
            new MoveSol(move4_1, move4_2, false),
            new MoveSol(move5_1, move5_2, false),
            new MoveSol(move6_1, move6_2, true),
            new MoveSol(move7_1, move7_2, false),
            new MoveSol(move8_1, move8_2, true),
            new MoveSol(move9_1, move9_2, false),
            new MoveSol(move10_1, move10_2, true),
            new MoveSol(move11_1, move11_2, false),
            new MoveSol(move12_1, move12_2, false),
            new MoveSol(move13_1, move13_2, false),
            new MoveSol(move14_1, move14_2, true),
            new MoveSol(move15_1, move15_2, false),
            new MoveSol(move16_1, move16_2, true),
            new MoveSol(move17_1, move17_2, false),
            new MoveSol(move18_1, move18_2, true),
            new MoveSol(move19_1, move19_2, false),
            new MoveSol(move20_1, move20_2, false),
            new MoveSol(move21_1, move21_2, false),
            new MoveSol(move22_1, move22_2, false),
            new MoveSol(move23_1, move23_2, false),
            new MoveSol(move24_1, move24_2, false),
            new MoveSol(move25_1, move25_2, true),
            new MoveSol(move26_1, move26_2, false),
            new MoveSol(move27_1, move27_2, false),
            new MoveSol(move28_1, move28_2, true)
        };
        
        StartCoroutine(GetSolution(list));

    }

    public void Level5Solution()
    {
        // create a solution cube list for level 1
        MoveSol[] list = {
            new MoveSol(move1_1, move1_2, false),
            new MoveSol(move2_1, move2_2, true),
            new MoveSol(move3_1, move3_2, false),
            new MoveSol(move4_1, move4_2, true),
            new MoveSol(move5_1, move5_2, false),
            new MoveSol(move6_1, move6_2, true),
            new MoveSol(move7_1, move7_2, false),
            new MoveSol(move8_1, move8_2, true),
            new MoveSol(move9_1, move9_2, false),
            new MoveSol(move10_1, move10_2, false),
            new MoveSol(move11_1, move11_2, true),
            new MoveSol(move12_1, move12_2, false),
            new MoveSol(move13_1, move13_2, false),
            new MoveSol(move14_1, move14_2, true),
            new MoveSol(move15_1, move15_2, false),
            new MoveSol(move16_1, move16_2, true),
            new MoveSol(move17_1, move17_2, false),
            new MoveSol(move18_1, move18_2, true),
            new MoveSol(move19_1, move19_2, false),
            new MoveSol(move20_1, move20_2, true),
            new MoveSol(move21_1, move21_2, false),
            new MoveSol(move22_1, move22_2, false),
            new MoveSol(move23_1, move23_2, false),
            new MoveSol(move24_1, move24_2, false),
            new MoveSol(move25_1, move25_2, true),
            new MoveSol(move26_1, move26_2, false),
            new MoveSol(move27_1, move27_2, true),
            new MoveSol(move28_1, move28_2, false),
            new MoveSol(move29_1, move29_2, true),
            new MoveSol(move30_1, move30_2, false),
            new MoveSol(move31_1, move31_2, true),
        };

        StartCoroutine(GetSolution(list));

    }

    IEnumerator GetSolution(MoveSol[] list)
    {
        Color oldColor1, oldColor2;

		helpButton.GetComponent<Button> ().interactable = false; // disable helpButton to show solution

        for (int iCnt = 0; iCnt < list.Length; iCnt++)
        {
            if(list[iCnt].isOne)
            {
                oldColor1 = list[iCnt].first.GetComponent<Renderer>().material.color;
                list[iCnt].first.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 1);

                if (list.Length == 31)
                {
                    if (iCnt == 3)
                    {
                        list[4].sec.SetActive(true);
                        list[5].first.SetActive(true);

                    }
                    else if (iCnt == 10)
                    {
                        list[18].first.SetActive(true);
                        list[18].sec.SetActive(true);
                    }
                    else if (iCnt == 17)
                    {
                        list[27].first.SetActive(true);
                        list[27].sec.SetActive(true);
                    }
                }

                yield return new WaitForSeconds(2);

                list[iCnt].first.GetComponent<Renderer>().material.color = oldColor1;
            }
            else
            {
                oldColor1 = list[iCnt].first.GetComponent<Renderer>().material.color;
                list[iCnt].first.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 1);
                oldColor2 = list[iCnt].sec.GetComponent<Renderer>().material.color;
                list[iCnt].sec.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 1);

                yield return new WaitForSeconds(2);

                list[iCnt].first.GetComponent<Renderer>().material.color = oldColor1;
                list[iCnt].sec.GetComponent<Renderer>().material.color = oldColor2;
            }
            
        }

//        list[4].sec.SetActive(false);
//        list[5].first.SetActive(false);
//        list[18].first.SetActive(false);
//        list[18].sec.SetActive(false);
//        list[27].first.SetActive(false);
//        list[27].sec.SetActive(false);

		gameplayButtons.UpdateHelpButton ();
	}
}
