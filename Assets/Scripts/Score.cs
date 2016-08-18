using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public Text scoreText;
	public int score;

	public float timeTotal = 0.0f;

    // Use this for initialization
  

    void Awake() {
		scoreText = GetComponent<Text>();
	}
		
	void Update()
	{
        timeTotal += Time.deltaTime;
		score = (int)(timeTotal * 100);

		scoreText.text = "Score: " + score.ToString();

        PlayerPrefs.SetInt("Score", score);
    }
}
