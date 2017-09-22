using UnityEngine;
using System.Collections;

public class ScoreDisplay : MonoBehaviour {
	
	public bool isPlayer1 = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(isPlayer1)
			this.GetComponent<GUIText>().text = "Player 1: " + ScoreManager.player1Score;
		else 
			this.GetComponent<GUIText>().text = "Player 2: " + ScoreManager.player2Score;
	}
}
