using UnityEngine;
using System.Collections;

public class feelChange : MonoBehaviour {

	float life;
	public GameObject calmSong;
	public GameObject fastSong;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		life=GameObject.Find("Main Camera").GetComponent<mechanics>().life;
		//print(life);
		if (life>2000){
			fastSong.SetActive(false);
			//print("Playing Calm Song");
			calmSong.SetActive(true);
		}
		if(life<=2000){
			calmSong.SetActive(false);
			fastSong.SetActive(true);
		}

		if(life==1500|| life==1000|| life==500){
			GameObject.Find("Main Camera").GetComponent<camShake>().shake=1;
		}
		if(life==10){
			GameObject.Find("Main Camera").GetComponent<camShake>().shakeAmount=0.4f;
			GameObject.Find("Main Camera").GetComponent<camShake>().decreaseFactor=1.0f;
			GameObject.Find("Main Camera").GetComponent<camShake>().shake=1;
		}
	}
}
