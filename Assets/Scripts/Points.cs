using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {
	public Transform particles;
	public float myVal =1;
	
	//will allso reference player 1 an two quite a bit
	Transform player1;
	Transform player2;
	
	public AudioClip coin;
	float distance = 2f;
	
	void Start () {

		player1 = GameObject.Find("Player 1").transform;
		player2 = GameObject.Find("Player 2").transform;
	}
	
	// Update is called once per frame
	void Update () {
		
		float dist = (player1.position - this.transform.position).magnitude;
		
		if(dist < distance)
		{
			ScoreManager.player1Score += myVal;
			
			Transform c = Instantiate(particles, this.transform.position, this.transform.localRotation) as Transform;
			c.GetComponent<ParticleSystem>().Play();
			GameObject.Find("AudioCoin").GetComponent<AudioSource>().Play();
			
			Destroy(this.gameObject);
			
			return;
		}
		
		dist = (player2.position - this.transform.position).magnitude;
		
		if(dist < distance)
		{
			ScoreManager.player2Score += myVal;
			
			Transform c = Instantiate(particles, this.transform.position, this.transform.localRotation) as Transform;
			c.GetComponent<ParticleSystem>().Play();
			GameObject.Find("AudioCoin").GetComponent<AudioSource>().Play();
			Destroy(this.gameObject);
			return;
		}
		
	
	}
}
