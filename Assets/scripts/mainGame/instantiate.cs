using UnityEngine;
using System.Collections;

public class instantiate : MonoBehaviour {

	public Transform redPrefab;
	public Transform bluePrefab;
	public Transform yellowPrefab;
	public Transform greenPrefab;
	public Transform orangePrefab;

	public bool gameActive;
	public bool firstStart;
	int roll;

	// Use this for initialization
	void Start () {
		firstStart=true;
	}
	
	// Update is called once per frame
	void Update () {
		//spawn new scenario on r button down
		if (Input.GetKeyDown("r")||firstStart==true){
			roll = Random.Range (1, 100);
			firstStart=false;
			gameActive=true;
			if (roll<=50){
				Instantiate (redPrefab, new Vector3(0, 0, 0), Quaternion.identity);
				Instantiate (redPrefab, new Vector3(2.5f, 0, 0), Quaternion.identity);
				Instantiate (bluePrefab, new Vector3(-2.5f, 0, 0), Quaternion.identity);
				Instantiate (bluePrefab, new Vector3(-2.5f, 0, 2.5f), Quaternion.identity);
				Instantiate (bluePrefab, new Vector3(-2.5f, 0, 5), Quaternion.identity);
				Instantiate (bluePrefab, new Vector3(2.5f, 0, 2.5f), Quaternion.identity);
				Instantiate (yellowPrefab, new Vector3(5, 0, 0), Quaternion.identity);
				Instantiate (yellowPrefab, new Vector3(5, 0, 5), Quaternion.identity);
				Instantiate (greenPrefab, new Vector3(5, 0, 2.5f), Quaternion.identity);
				Instantiate (greenPrefab, new Vector3(2.5f, 0, 5), Quaternion.identity);
				Instantiate (orangePrefab, new Vector3(0, 0, 2.5f), Quaternion.identity);
				Instantiate (orangePrefab, new Vector3(0, 0, 5), Quaternion.identity);
			}
			else if (roll>50){
				Instantiate (bluePrefab, new Vector3(0, 0, 0), Quaternion.identity);
				Instantiate (bluePrefab, new Vector3(2.5f, 0, 0), Quaternion.identity);
				Instantiate (bluePrefab, new Vector3(-2.5f, 0, 0), Quaternion.identity);
				Instantiate (orangePrefab, new Vector3(-2.5f, 0, 2.5f), Quaternion.identity);
				Instantiate (bluePrefab, new Vector3(-2.5f, 0, 5), Quaternion.identity);
				Instantiate (redPrefab, new Vector3(2.5f, 0, 2.5f), Quaternion.identity);
				Instantiate (yellowPrefab, new Vector3(5, 0, 0), Quaternion.identity);
				Instantiate (greenPrefab, new Vector3(5, 0, 5), Quaternion.identity);
				Instantiate (yellowPrefab, new Vector3(5, 0, 2.5f), Quaternion.identity);
				Instantiate (redPrefab, new Vector3(2.5f, 0, 5), Quaternion.identity);
				Instantiate (redPrefab, new Vector3(0, 0, 2.5f), Quaternion.identity);
				Instantiate (yellowPrefab, new Vector3(0, 0, 5), Quaternion.identity);
			}
		}
	}
}

