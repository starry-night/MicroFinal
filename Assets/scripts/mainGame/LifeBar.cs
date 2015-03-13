using UnityEngine;
using System.Collections;

public class LifeBar : MonoBehaviour {

	public GameObject bloodShrink;
	float startlife;
	float originalScale;

	// Use this for initialization
	void Start () {
		originalScale = bloodShrink.transform.localScale.x;
		//print("originalScale :"+originalScale);
		startlife=GameObject.Find("Main Camera").GetComponent<mechanics>().life;
		//print("startlife :"+startlife);
	}
	
	// Update is called once per frame
	void Update () {
		float lifeValue;
		lifeValue=(float)GameObject.Find("Main Camera").GetComponent<mechanics>().life;
		if(lifeValue>0){
			float percent = (lifeValue/startlife);
			bloodShrink.transform.localScale = new Vector3( originalScale * percent,1f,1f);
//			print ("lifeValue "+lifeValue);
//			print ("startlife "+startlife);
//			print("life/start "+percent);
		}
	}
}
