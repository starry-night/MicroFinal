using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class endCondition : MonoBehaviour {

	public bool startAndActivate = true;
	public int score;
	public int winOrNot;
	public Material backGround;
	public Text OutCome;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (startAndActivate) {

			winOrNot = PlayerPrefs.GetInt ("winOrNot");
			score = PlayerPrefs.GetInt ("score");

			if (winOrNot == 1) {
				IfWin ();
			}
			if (winOrNot == 0) {
				IfLose ();
			}
		} 
	}

	void IfWin(){
		backGround.color = Color.blue;
		OutCome.text = "you win"+"\br"+"score:"+ score;
	}

	void IfLose(){
		backGround.color = Color.black;
		OutCome.text = "you lose";
	}
}
