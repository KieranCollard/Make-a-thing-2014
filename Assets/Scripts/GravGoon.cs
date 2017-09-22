using UnityEngine;
using System.Collections;

public class GravGoon : MonoBehaviour {
	//strength of our grav gun
	//... this may vary
	
	public float strength = 3;
	
	//we will be reffering to uor players a low
	Transform player1;
	Transform player2;
	
	float timer1 =0;
	float timer2 =0;
	
	public float Range = 10;
	// Use this for initialization
	void Start () {
		player1 = GameObject.Find("Player 1").transform;
		player2 = GameObject.Find("Player 2").transform;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//pull direction
		Vector3 dir = this.transform.position - player1.position;
		
		//normalize and multipy by speed
		if(dir.magnitude <= Range)
			player1.GetComponent<Movement>().gravGunsEffect = (dir * strength * Time.deltaTime);
		else 
			player1.GetComponent<Movement>().gravGunsEffect =Vector3.zero;
		
		//check if we can grab them 
		if(dir.magnitude <= 1 && timer1 == 0)
		{
			//grab them
			player1.GetComponent<Movement>().enabled = false;
			GameObject.Find("BlackNoise").GetComponent<AudioSource>().Play();
			timer1 += Time.deltaTime;
			
			
		}
		else if( timer1 !=0)
		{
			timer1 += Time.deltaTime;
			
			if(timer1 >=2)
			{
				//relese them 
				player1.GetComponent<Movement>().enabled = true;
			}
			if (timer1 >= 2.5f)
			{
				timer1 =0;
			}
		}
		
		dir = this.transform.position - player2.position;
		if(dir.magnitude <= Range)
			player2.GetComponent<Movement>().gravGunsEffect = (dir * strength * Time.deltaTime);
		else 
			player2.GetComponent<Movement>().gravGunsEffect = Vector3.zero;
		
		if(dir.magnitude <= 0.5 && timer2 == 0)
		{
			//grab them
			player2.GetComponent<Movement>().enabled = false;
			timer2 += Time.deltaTime;
			GameObject.Find("BlackNoise").GetComponent<AudioSource>().Play();
			
			
		}
		else if( timer2 !=0)
		{
			timer1 += Time.deltaTime;
			
			if(timer2 >=2)
			{
				//relese them 
				print ("re-enable");
				player2.GetComponent<Movement>().enabled = true;
			}
			if (timer2 >= 2.5f)
			{
				timer2 =0;
			}
		}
	}
}
