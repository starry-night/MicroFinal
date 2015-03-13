using UnityEngine;
using System.Collections;

public class restartGame : MonoBehaviour {

	public int menuSce = 0;
	public int reSce = 1;
	public bool isThisRestartBut = true;

	Vector3 initialScale;

	// Use this for initialization
	void Start () {
		initialScale= new Vector3 (transform.localScale.x, transform.localScale.y, transform.localScale.z);
	}

	void OnMouseEnter () {
		//this.gameObject.light.intensity= 1;
		this.gameObject.transform.localScale = initialScale*1.1f;
	}
	
	void OnMouseExit () {
		//this.gameObject.light.intensity= 0;
		this.gameObject.transform.localScale = initialScale;
	}

	// Update is called once per frame
	void OnMouseDown () {
		if(isThisRestartBut){
			Application.LoadLevel(reSce);
		}else{
			Application.LoadLevel(menuSce);
		}
	}
}
