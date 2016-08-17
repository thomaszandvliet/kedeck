using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour {

	public Sprite pauseSprite;
	public Sprite playSprite;


	public Sprite spriteToChangeTo;
	// Use this for initialization
	void Start () {
	
	}

	public void PauseGame () {
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} else if (Time.timeScale == 0) {
			Time.timeScale = 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		

	public void ChangeImage(Image myImageToUpdate)
	{
		myImageToUpdate.sprite = spriteToChangeTo;
	}

//	public void ChangeImage(Image myImageToUpdate)
//	{
//		if (originalSprite == !spriteToChangeTo) {
//			myImageToUpdate.sprite = spriteToChangeTo;
//			Debug.Log ("1");
//		} else if (spriteToChangeTo == !originalSprite) {
//			myImageToUpdate.sprite = originalSprite;
//			Debug.Log ("2");
//		}
//	}


			
}
