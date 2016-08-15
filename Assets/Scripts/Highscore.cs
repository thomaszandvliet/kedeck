using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {

    public Text scoreText;
    public Text highscoreText;
    public int highscore;
    public int score;
    // Use this for initialization
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        highscore = PlayerPrefs.GetInt("High Score");
    }

    void Awake()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("High Score", highscore);          
        }

        scoreText.text = "Highscore: " + highscore.ToString() + "\nYour Score: " + score.ToString(); ;
    }
}
