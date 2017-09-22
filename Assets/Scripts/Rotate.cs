using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	
	public float speed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		this.transform.RotateAround(Vector3.forward,speed * Time.deltaTime);// = new Vector3(this.transform.rotation.eulerAngles.x + 20 * speed * Time.deltaTime,0, 0);
	}
}
