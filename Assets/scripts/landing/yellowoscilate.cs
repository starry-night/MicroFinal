using UnityEngine;
using System.Collections;

public class yellowoscilate : MonoBehaviour {
	private Vector3 initialScale;
	// Use this for initialization
	void Start () {
		initialScale= new Vector3 (transform.localScale.x, transform.localScale.y, transform.localScale.z);
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.localScale = initialScale*(Mathf.PingPong(Time.time*0.05f,0.07f)+1f);
		this.gameObject.transform.position+=new Vector3 (0, 0.004f, 0) * Mathf.Sin (Time.time*2f);
	}
}
