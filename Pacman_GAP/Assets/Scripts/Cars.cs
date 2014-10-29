using UnityEngine;
using System.Collections;

public class Cars : MonoBehaviour {

	public float leftConstraint = 0f;
	public float rightConstraint = 0f;
	public float buffer = 1f;
	public float distanceZ = 0f;
	
	void Awake() 
	{
		leftConstraint = Camera.main.ScreenToWorldPoint(new Vector3(0f, 0f, distanceZ)).x;
		rightConstraint = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, distanceZ)).x;
	}

	void Update() 
	{
	
	}
}
