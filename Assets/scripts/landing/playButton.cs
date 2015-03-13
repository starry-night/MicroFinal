using UnityEngine;
using System.Collections;

public class playButton : MonoBehaviour {
	private Vector3 initialScale;
	private bool toggle =true;
	public GameObject sound;
	// Use this for initialization
	void Start () {
		initialScale= new Vector3 (transform.localScale.x, transform.localScale.y, transform.localScale.z);
	}
	
	// Update is called once per frame
	void Update () {
		if (toggle==true){
		this.gameObject.transform.localScale = initialScale*(Mathf.PingPong(Time.time*1.4f*0.03f,0.06f)+1f);
		this.gameObject.transform.position+=new Vector3 (0, 0.004f, 0) * Mathf.Sin (Time.time*2f);	
		}
	}
	void OnMouseEnter () {
		//toggle=false;
		this.gameObject.light.intensity= 1;
		sound.SetActive(true);
	}
	
	void OnMouseExit () {
		//toggle=true;
		this.gameObject.light.intensity= 0;
		sound.SetActive(false);
	}
	void OnMouseDown(){
		Application.LoadLevel("microbiome");
	}
}
