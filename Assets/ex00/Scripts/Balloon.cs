using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    private int sec = 0;
    private float timer = 0.0f;
    private float waitTime = 1.0f;

    private int breath = 100;
    private int countdown = 10;

    void Update()
    {
	timer += Time.deltaTime;
	if (timer > waitTime) {
		sec++;
		countdown--;
		timer = timer - waitTime;
		if (breath <= 90)
			breath += 10;
		if (countdown == 0) {
			Destroy(gameObject);
			Debug.Log("Balloon life time: " + sec + "s");
		}
	}
        if (Input.GetKeyDown("space")) {
		if (breath >= 30) {
			breath -= 30;
			countdown = 10;
			transform.localScale += new Vector3(1, 1, 0);
			if (transform.localScale.x == 10) {
				Destroy(gameObject);
				Debug.Log("Balloon life time: " + sec + "s");
			}
		}
	}
    }
}
