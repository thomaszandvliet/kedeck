using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	//public GUIText 
	public Text scoreText;
	private int score;

	public float timeTotal = 0.0f;

	// Use this for initialization
	void Start () {

	}

	void Awake() {
		scoreText = GetComponent<Text>();
	}
		
	void Update()
	{
		timeTotal += Time.deltaTime;
		score = (int)(timeTotal * 100);

		scoreText.text = "Score: " + score.ToString();
	}
}
