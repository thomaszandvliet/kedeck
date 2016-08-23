using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour {
	public GameObject enemyOne;
	public GameObject enemyTwo;
    public GameObject enemyThree;

	public float spawnTimeOne = 0.5f;
	public float spawnTimeTwo = 5f;
	public float spawnTimeThree = 5f;
	public int score;
	public bool spawnTwo;
	public float timeTotal = 0.0f;

	void Awake () { }

	void Start () {
		InvokeRepeating("SpawnEnemyOne", 1f, spawnTimeOne);
        InvokeRepeating("SpawnEnemyThree", 1f, spawnTimeThree);
	}

	void Update () {
		timeTotal += Time.deltaTime;
		score = (int)(timeTotal * 100);

		if (score >= 2500 && spawnTwo == false) {
			InvokeRepeating("SpawnEnemyTwo", 1f, spawnTimeTwo);
			spawnTwo = true;	
		}
	}

	void SpawnEnemyOne () {
		float spawnY = Random.Range (((-Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y) + 0.6f), (Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y - 0.6f));
		Vector2 spawnPosition = new Vector2 (Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width, 0)).x + 7, spawnY);

		Instantiate (enemyOne, spawnPosition, Quaternion.Euler (0, 0, 270));
	}

	void SpawnEnemyTwo () {
		float spawnY = Random.Range(((-Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y) + 0.6f), (Camera.main.ScreenToWorldPoint (new Vector2 (0, Screen.height)).y - 0.6f));
		Vector2 spawnPosition = new Vector2 (Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width, 0)).x + 7, spawnY);

		Instantiate (enemyTwo, spawnPosition, Quaternion.Euler(0,0,270));
	}

    void SpawnEnemyThree()
    {
        //int SpawnLocation = Random.Range(0, 1);
        if (Random.Range(0, 2) == 0)
        {
            float spawnY = Random.Range(((-Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height / 6)).y) + 0.0f), (Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height * 1.3f)).y - 0.6f));
            Vector2 spawnPosition = new Vector2(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x + 1, spawnY);
            Instantiate(enemyThree, spawnPosition, Quaternion.Euler(0, 0, 0));
        }
        else
            {
            float spawnY = Random.Range(((-Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height * 1.15f)).y) - 0.6f), (Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height / 6)).y + 0.0f));
            Vector2 spawnPosition = new Vector2(Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x + 1, spawnY);
            Instantiate(enemyThree, spawnPosition, Quaternion.Euler(0, 0, 0));
        }

       
    }
}
