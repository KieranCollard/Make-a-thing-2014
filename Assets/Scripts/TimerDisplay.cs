using UnityEngine;
using System.Collections;

public class TimerDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Play.time <0)
		{
			Play.time =0;
		}
		this.GetComponent<GUIText>().text = "Time: " + Play.time.ToString();
		
	}
}
