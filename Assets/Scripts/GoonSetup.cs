using UnityEngine;
using System.Collections;

public class GoonSetup : MonoBehaviour {
	
	public Transform gravGoon;
	// Use this for initialization
	void Start () {
	
			
		int number = Random.Range(1,2);
		for(int i =0; i < number; ++i)
		{
			Transform c = Instantiate(gravGoon) as Transform;
			c.position = new Vector3(Random.Range(-Arena.Size, Arena.Size), Random.Range(-Arena.Size, Arena.Size), 0 );
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
