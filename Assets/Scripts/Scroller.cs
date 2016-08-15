using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour {

	public float scrollSpeed = 0.1f;

	private Vector2 offset;

	void Start ()
	{

	}

	void Update ()
	{
		offset = new Vector2 (Time.time * scrollSpeed, 0);

		GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
