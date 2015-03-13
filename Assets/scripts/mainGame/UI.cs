using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour {

	Text life;

	// Use this for initialization
	void Start () {
		life=GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		int lifeValue;
		lifeValue=GameObject.Find("Main Camera").GetComponent<mechanics>().life;
		if (lifeValue>0){
			life.text="Life: " + lifeValue;
		}
		else{
			life.text="GAME OVER";
		}
	}
}
