using UnityEngine;
using System.Collections;

public class oscillate : MonoBehaviour {
	private Vector3 initialScale;
	private int roll;
	public float scaleMax=0.05f;
	public float scaleMin=0.03f;
	// Use this for initialization
	void Start () {
		initialScale= new Vector3 (transform.localScale.x, transform.localScale.y, transform.localScale.z);
		roll = Random.Range(1,10);
	}
	
	// Update is called once per frame
	void Update () {
		/*float xRange;
		float zRange;
		xRange=Random.Range(-0.004f,0.004f);
		zRange=Random.Range(-0.004f,0.004f);*/
		if(roll<3){
			this.gameObject.transform.localScale = initialScale*(Mathf.PingPong(Time.time*scaleMin,scaleMax)+1f);
			this.gameObject.transform.position+=new Vector3 (-0.004f, 0.004f, 0.004f) * Mathf.Sin (Time.time*2f);	
		}
		if(roll>=3&&roll<5){
			this.gameObject.transform.localScale = initialScale*(Mathf.PingPong(Time.time*scaleMin,scaleMax)+1f);
			this.gameObject.transform.position+=new Vector3 (0.004f, 0.004f, -0.004f) * Mathf.Sin (Time.time*2f);	
		}
		if(roll>=5&&roll<8){
			this.gameObject.transform.localScale = initialScale*(Mathf.PingPong(Time.time*scaleMin,scaleMax)+1f);
			this.gameObject.transform.position-=new Vector3 (-0.004f, 0.004f, 0.004f) * Mathf.Sin (Time.time*2f);
		}
		else{
			this.gameObject.transform.localScale = initialScale*(Mathf.PingPong(Time.time*scaleMin,scaleMax)+1f);
			this.gameObject.transform.position-=new Vector3 (0.004f, 0.004f, -0.004f) * Mathf.Sin (Time.time*2f);	
		}
	}
}
