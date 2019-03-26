using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject Player1;
	public GameObject Player2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w") && Player1.transform.position.y < 3.49f) {
			Player1.transform.Translate(0, 0.1f, 0);
		}
		if (Input.GetKey("s") && Player1.transform.position.y > -3.49f) {
			Player1.transform.Translate(0, -0.1f, 0);
		}
		if (Input.GetKey("up") && Player2.transform.position.y < 3.49f) {
			Player2.transform.Translate(0, 0.1f, 0);
		}
		if (Input.GetKey("down") && Player2.transform.position.y > -3.49f) {
			Player2.transform.Translate(0, -0.1f, 0);
		}
	}
}
