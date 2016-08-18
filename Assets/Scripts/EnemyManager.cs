using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour {

	public GameObject enemyOne;
	public GameObject enemyTwo;


	public float spawnTimeOne = 0.5f;
	public float spawnTimeTwo = 0f;
	public int score;
	public bool spawnTwo;
	public float timeTotal = 0.0f;
	// Use this for initialization

	void Awake () {
	}

	void Start () {
		InvokeRepeating("SpawnEnemyOne", 1f, spawnTimeOne);
	}


	// Update is called once per frame
	void Update () {
		timeTotal += Time.deltaTime;
		score = (int)(timeTotal * 100);


		if (score >= 1000 && spawnTwo == false) {
			InvokeRepeating("SpawnEnemyTwo", 1f, spawnTimeTwo);
			spawnTwo = true;	
		}


	}

	void SpawnEnemyOne () {
		float spawnY = Random.Range(((-Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y) + 0.6f), (Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y - 0.6f));
		Vector2 spawnPosition = new Vector2 (Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width, 0)).x + 7, spawnY);

		Instantiate (enemyOne, spawnPosition, Quaternion.Euler(0,0,270));
	}


	void SpawnEnemyTwo () {
		float spawnY = Random.Range(((-Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y) + 0.6f), (Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y - 0.6f));
		Vector2 spawnPosition = new Vector2 (Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width, 0)).x + 7, spawnY);


		Instantiate (enemyTwo, spawnPosition, Quaternion.Euler(0,0,270));
	}
}
