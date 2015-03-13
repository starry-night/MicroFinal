using UnityEngine;
using System.Collections;

public class EndToMove : MonoBehaviour {

	public Transform EndPosition;
	public GameObject Mover;
	public GameObject sound;

	bool isEnd = false;

	// Use this for initialization
	void Start () {
	
	}

	void ENDShow(bool data){
		isEnd = data;
	}
	
	// Update is called once per frame
	void Update () {
		if(isEnd){
			sound.audio.enabled = true;
			if(Mover.transform.position.z > EndPosition.position.z){
				float adj =Mover.transform.position.z -  EndPosition.position.z;
				Mover.transform.position = new Vector3(Mover.transform.position.x,Mover.transform.position.y,Mover.transform.position.z-0.1f*adj);
			}
		}
	}
}
