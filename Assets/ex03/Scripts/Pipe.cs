using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

	//private float speed = 0.05f;
	public static int score = 0;
	private Vector3 origin;
	void Start()
	{
		origin = new Vector3(10f, 2.5f, 0);
	}

	void Update () {
		if (transform.position.x < -5f) {
			if (Bird.speed != 0 && name == "pipe")
				Bird.speed += 0.02f;
			transform.position = origin;
			score += 5;
		}
		transform.Translate(-Bird.speed, 0, 0);
	}
}
