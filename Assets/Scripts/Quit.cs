using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Play.time <= 0)
		{
			this.GetComponent<GUITexture>().enabled = true;
		}
		else
		{
			this.GetComponent<GUITexture>().enabled = false;
		}
		if(Input.GetMouseButtonDown(0))
		{
			if(this.GetComponent<GUITexture>().HitTest(Input.mousePosition))
			{
				Application.Quit();
			}
		}
	
	}
}
