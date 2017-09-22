using UnityEngine;
using System.Collections;


//handles the genric movement o fboth player 1 and two



public class Movement : MonoBehaviour {
	//are our contrls player one
	public bool isPlayer1 = true;
	//there is also going ot be a vector three that is 'grav guns' effect
	
	public Vector3 gravGunsEffect = Vector3.zero;
	//how fast do we move
	public float speed;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//quicly grab our curent positione in case we are about to do an illegal move
		
		Vector3 lastPos =this.transform.position;
		
		//this happens regarldess of movement
		this.transform.position += gravGunsEffect;
		if(isPlayer1)
		{
			if(Input.GetKey(KeyCode.A))
			{
				//move left at speed 
				this.transform.position += (Vector3.left * speed * Time.deltaTime);
			}
			if(Input.GetKey(KeyCode.S))
			{
				//move left at speed 
				this.transform.position += (Vector3.down * speed * Time.deltaTime);
			}
			if(Input.GetKey(KeyCode.D))
			{
				//move left at speed 
				this.transform.position += (Vector3.right * speed * Time.deltaTime);
			}
			if(Input.GetKey(KeyCode.W))
			{
				//move left at speed 
				this.transform.position += (Vector3.up * speed * Time.deltaTime);
			}
		}
		else
		{
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				//move left at speed 
				this.transform.position += (Vector3.left * speed * Time.deltaTime);
			}
			if(Input.GetKey(KeyCode.DownArrow))
			{
				//move left at speed 
				this.transform.position += (Vector3.down * speed * Time.deltaTime);
			}
			if(Input.GetKey(KeyCode.RightArrow))
			{
				//move left at speed 
				this.transform.position += (Vector3.right * speed * Time.deltaTime) ;
			}
			if(Input.GetKey(KeyCode.UpArrow))
			{
				//move left at speed 
				this.transform.position += (Vector3.up * speed * Time.deltaTime);
			}
		}
	
		//now we need to make sure that that move wasn't illegal. 
		//if it was discard
		if((this.transform.position - new Vector3(0,0,0)).magnitude > Arena.Size)
		{
			//do not move
			this.transform.position = lastPos - new Vector3(0.00001f, 0.00001f, 0);
		}
	}
}
