using UnityEngine;
using System.Collections;

public class ScoreScatter : MonoBehaviour {

	public Transform onePoint;
	public Transform twoPoint;
	public Transform threePoint;
	
	float time = -1;
	float timer =0;
	// Use this for initialization
	void Start () {
		
		for(int i =1 ; i < 16; ++i)
		{
			int t = Random.Range(1,4);
			Transform cloneType;
			switch(t)
			{
			case 1:
				cloneType = onePoint;
				break;
			case 2:
				cloneType = twoPoint;
				break;
			case 3:
				cloneType = threePoint;
				break;
			default:
				cloneType = onePoint;
				break;
			}
				
			//clone our object and place it randomly
			Transform clone = Instantiate(cloneType) as Transform;
			clone.position = new Vector3 (Random.Range(-Arena.Size, Arena.Size), Random.Range(-Arena.Size, Arena.Size - 0.5f), 0);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//if our time is zero 
		if(time == -1)
		{
			//generate a random time
			time = Random.Range(0.5f, 5);
		}
		
		timer += Time.deltaTime;
		
		if(timer >= time)
		{
			//spawn a thing
				int t = Random.Range(1,4);
			Transform cloneType;
			switch(t)
			{
			case 1:
				cloneType = onePoint;
				break;
			case 2:
				cloneType = twoPoint;
				break;
			case 3:
				cloneType = threePoint;
				break;
			default:
				cloneType = onePoint;
				break;
			}
				
			//clone our object and place it randomly
			Transform clone = Instantiate(cloneType) as Transform;
			clone.position = new Vector3 (Random.Range(-Arena.Size, Arena.Size), Random.Range(-Arena.Size, Arena.Size - 0.5f), 0);
			
			timer = 0;
			time = Random.Range(0.5f, 5);
		}
 	}
}
