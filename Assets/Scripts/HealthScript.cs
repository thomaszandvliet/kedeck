using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour {

	private SpriteRenderer spriteRenderer;

	private int lifePoints;

	public Sprite Health;
	public Sprite HealthLow;

	// Use this for initialization
	void Start () {
		//GameObject Life = GameObject.Find("Player");
		//Player LifeTotal = Life.GetComponent<Player>();

		//lifePoints = LifeTotal.lifePoints;

		//Debug.Log(GameObject.Find("Player").GetComponent<Player>().lifePoints);

		spriteRenderer = GetComponent<SpriteRenderer>();
		if (spriteRenderer.sprite == null) 
			spriteRenderer.sprite = Health;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject Life = GameObject.Find("Player");
		Player LifeTotal = Life.GetComponent<Player>();

		lifePoints = LifeTotal.lifePoints;

		if (lifePoints == 0) {
			Debug.Log ("low!");
			spriteRenderer.sprite = HealthLow;
		}
			


		//Debug.Log ("Aantal levens: ");
	}
}
