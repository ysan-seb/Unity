using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	public GameObject pipeA;
	public GameObject pipeB;

	public static float speed = 0.05f;
	private float gravity = -1.81f;
	private int sec = 0;
    private float timer = 0.0f;
    private float waitTime = 1.0f;
	private bool end = false;
	
	void Update () {
		timer += Time.deltaTime;
		if (timer > waitTime && end == false) {
			sec++;
			timer = timer - waitTime;
		}
		transform.Translate(0, gravity * Time.deltaTime, 0);
		if (Input.GetKeyDown("space") && gravity != 0) {
			transform.Translate(0, 1, 0);
		}
		if (((transform.position.x > (pipeA.transform.position.x - 1f) && (transform.position.x < pipeA.transform.position.x + 1f)) && (transform.position.y < 0.90f || transform.position.y > 3.81f) 
		|| (transform.position.x > (pipeB.transform.position.x - 1f) && (transform.position.x < pipeB.transform.position.x + 1f)) && (transform.position.y < 0.90f || transform.position.y > 3.81f)) && end == false || transform.position.y < -2.40f && end == false) {
			end = true;
			speed = 0;
			gravity = 0;
			Debug.Log("Score: " + Pipe.score);
			Debug.Log("Time: " + sec + "s");
		}
	}
}
