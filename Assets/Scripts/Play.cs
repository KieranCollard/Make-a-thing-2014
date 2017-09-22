using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {
	public static float time = 15;
	// Use this for initialization
	void Start () {
	
		Time.timeScale = 1;
		this.GetComponent<GUITexture>().enabled = false;
	}
	
	
	// Update is called once per frame
	void Update () {
		
		time = 15 - Time.timeSinceLevelLoad;
		
		if(time <=0)
		{
			Time.timeScale =0;
			this.GetComponent<GUITexture>().enabled = true;
		}
		
		if(Input.GetMouseButtonDown(0))
		{
			if(this.GetComponent<GUITexture>().HitTest(Input.mousePosition))
			{
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	
	}
}
