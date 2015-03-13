using UnityEngine;
using System.Collections;

public class interact : MonoBehaviour {
	public Transform redPrefab;
	public Transform bluePrefab;
	public Transform yellowPrefab;
	public Transform greenPrefab;
	public Transform orangePrefab;
	

	public bool CanMove = true;

	int click = -1;
	int roll;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (CanMove) {
			Move ();
		}

	}

	void GetClick(int data){
		click = data;
		if(CanMove){
		Move ();
		}
	}

	void Move(){
		GameObject[] red = GameObject.FindGameObjectsWithTag("red");
		GameObject[] blue = GameObject.FindGameObjectsWithTag("blue");
		GameObject[] yellow = GameObject.FindGameObjectsWithTag("yellow");
		GameObject[] green = GameObject.FindGameObjectsWithTag("green");
		GameObject[] orange = GameObject.FindGameObjectsWithTag("orange");
		if (Input.GetKeyDown("1")||click==1){
			if (red.Length>1 ){
				PlaySound();
				int i = Random.Range(1,red.Length);
				//using 1 so it doesn't destroy the original prefab in the array
				//original prefab is index 0
				Vector3 redPos=red[i].transform.position;
				Destroy(red[i].gameObject);
				Instantiate (orangePrefab, redPos, Quaternion.identity);
			}
			else {
				//some error message text on screen 
			}
		}
		
		if (Input.GetKeyDown("2")||click==2){
			PlaySound();
			if (blue.Length>1){
				PlaySound();
				int i = Random.Range(1,blue.Length);
				Vector3 bluePos=blue[i].transform.position;
				Destroy(blue[i].gameObject);
				Instantiate (redPrefab, bluePos, Quaternion.identity);
			}
			else {
				//some error message text on screen
			}
		}
		if (Input.GetKeyDown("3")||click==3){
			if (yellow.Length>1){
				PlaySound();
				int i = Random.Range(1,yellow.Length);
				Vector3 yellowPos=yellow[i].transform.position;
				Destroy(yellow[i].gameObject);
				Instantiate (bluePrefab, yellowPos, Quaternion.identity);
			}
			else {
				//some error message text on screen
			}
		}
		if (Input.GetKeyDown("4")||click==4){
			PlaySound();
			if (green.Length>1){
				PlaySound();
				int i = Random.Range(1,green.Length);
				Vector3 greenPos=green[i].transform.position;
				Destroy(green[i].gameObject);
				Instantiate (yellowPrefab, greenPos, Quaternion.identity);
			}
			else {
				//some error message text on screen
			}
		}
		if (Input.GetKeyDown("5")||click==5){
			PlaySound();
			if (orange.Length>1){
				PlaySound();
				int i = Random.Range(1,orange.Length);
				Vector3 orangePos=orange[i].transform.position;
				Destroy(orange[i].gameObject);
				Instantiate (greenPrefab, orangePos, Quaternion.identity);
			}
			else {
				//some error message text on screen
			}
		}
		click = -1;
	}
	

	void PlaySound(){
		if(!gameObject.audio.enabled){
			gameObject.audio.enabled = true;
		}else {
			gameObject.audio.Play();
		}
	}
}
