using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	private SpriteRenderer frogSprites;
	public Sprite[] frog;

	void Start()
	{
		//frogSprites.GetComponent<SpriteRenderer>().sprite = frog[0];
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.up * 0.625f);
		}

		else if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.Translate(Vector3.left * 0.625f);
		}

		else if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			transform.Translate(Vector3.down * 0.625f);
		}

		else if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.Translate(Vector3.right * 0.625f);
		}
	}

}