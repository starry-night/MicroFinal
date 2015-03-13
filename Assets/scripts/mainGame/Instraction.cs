using UnityEngine;
using System.Collections;

public class Instraction : MonoBehaviour {

	public GameObject ClickButtom;
	public GameObject InstractionHere;
	public GameObject CameraHere;

	bool ShowHere = true;

	Vector3 initialScale;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("LevelNow") > 1){
			InstractionHere.renderer.enabled= false;
			ClickButtom.renderer.enabled= false;
		}

		initialScale= new Vector3 (transform.localScale.x, transform.localScale.y, transform.localScale.z);
		
	}

	/*void OnMouseEnter () {
		//this.gameObject.light.intensity= 1;
		this.gameObject.transform.localScale = initialScale*1.1f;
	}
	
	void OnMouseExit () {
		//this.gameObject.light.intensity= 0;
		this.gameObject.transform.localScale = initialScale;
	}
	*/
	void Update () {

			this.gameObject.transform.localScale = initialScale*(Mathf.PingPong(Time.time*1.4f*0.09f,0.14f)+1f);
			this.gameObject.transform.position+=new Vector3 (0, 0.004f, 0) * Mathf.Sin (Time.time*2f);	
		
	}
	// Update is called once per frame
	void OnMouseDown () {

		InstractionHere.renderer.enabled= false;
		ClickButtom.renderer.enabled= false;
		CameraHere.SendMessage("getStart",true);

	}
}
