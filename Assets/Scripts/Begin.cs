﻿using UnityEngine;
using System.Collections;

public class Begin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButtonDown(0))
		{
			if(this.GetComponent<GUITexture>().HitTest(Input.mousePosition))
			{
				Application.LoadLevel("Level");
			}
		}
	
	}
}
