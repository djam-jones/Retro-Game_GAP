using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;

	void Start () {
		rigidbody2D.AddForce(new Vector2(-speed, 0f) * Time.deltaTime);
		this.rigidbody2D.rotation = 0;
	}

	void Update () {
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.up * speed);
		}
		
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(Vector3.left * speed);
		}

		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(Vector3.down * speed);
		}

		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(Vector3.right * speed);
		}
	}
}
