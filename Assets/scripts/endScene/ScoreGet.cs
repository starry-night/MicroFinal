using UnityEngine;
using System.Collections;

public class ScoreGet : MonoBehaviour {

	public TextMesh Score;
	int scoreNow;

	// Use this for initialization
	void Start () {
		scoreNow = PlayerPrefs.GetInt( "score" );
	}
	
	// Update is called once per frame
	void Update () {
		Score.text = ""+ scoreNow;
	}
}
