using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour {

    private SpriteRenderer spriteRenderer;

    public Sprite pauseSprite;
    public Sprite playSprite;

	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null) 
            spriteRenderer.sprite = pauseSprite;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        ChangeImage();
    }

    public void ChangeImage()
    {
        if (spriteRenderer.sprite == pauseSprite) 
        {
            spriteRenderer.sprite = playSprite;
            Time.timeScale = 0;
        }
        else
        {
            spriteRenderer.sprite = pauseSprite; 
            Time.timeScale = 1;
        }
    }		
}
