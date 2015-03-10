using UnityEngine;
using System.Collections;

public class ScoreText : MonoBehaviour {
	public int displayScore = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		print (displayScore);
		this.guiText.text = "Score: " + displayScore;
	}
}

