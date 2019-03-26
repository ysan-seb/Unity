using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public static float speed = 0.0f;
	public static int direction = 1;
	public static bool end = false;
	public static int score = -15;
	private Vector3 origin;

	void Start() {
		origin = transform.position;
	}

	void Update()
	{
		if (transform.position.y > 4.70f || transform.position.y < -4.70f)
            direction = -direction;
		speed = Mathf.Clamp(speed - 0.05f, 0f, 10f);
		if (end == false && speed < 5f && transform.position.y > 3.5f && transform.position.y < 4f) {
			transform.position = new Vector3(10, 0, 0);
			end = true;
			Debug.Log("Score: " + score);
		} else if (end == false && speed == 0 && origin != transform.position) {
			origin = transform.position;
			score += 5;
			Debug.Log("Score: " + score);
		}
		transform.Translate(0, (speed * direction) * Time.deltaTime, 0);

	}
}
