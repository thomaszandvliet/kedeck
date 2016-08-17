using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScoreMenu : MonoBehaviour {

	public Text highscoreText;
	public int highscore;

	// Use this for initialization
	void Start()
	{
		highscore = PlayerPrefs.GetInt("High Score");
	}

	void Awake()
	{
		highscoreText = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		highscoreText.text = "Highscore:\n" + highscore.ToString();
	}
}
