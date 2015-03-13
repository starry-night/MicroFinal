using UnityEngine;
using System.Collections;

public class butInteract : MonoBehaviour {
	public GameObject messageReciver;
	public int messageNum;

	void OnMouseDown(){
		messageReciver.SendMessage("GetClick",messageNum);
	}
}
