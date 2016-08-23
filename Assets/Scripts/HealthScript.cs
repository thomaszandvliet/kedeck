using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour {
	private int lifePoints;
	private SpriteRenderer spriteRenderer;
	public Sprite Health;
	public Sprite HealthLow;

	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		if (spriteRenderer.sprite == null) 
			spriteRenderer.sprite = Health;
	}
	
	void Update () {
		GameObject Life = GameObject.Find("Player");
		Player LifeTotal = Life.GetComponent<Player>();

		lifePoints = LifeTotal.lifePoints;

		if (lifePoints == 0) {
			spriteRenderer.sprite = HealthLow;
		}

		if (lifePoints == 1) {
			spriteRenderer.sprite = Health;
		}
	}
}
