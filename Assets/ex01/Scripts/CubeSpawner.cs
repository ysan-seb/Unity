using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
	public GameObject Object;
	public GameObject Target;
	private GameObject Clone;
	private float spawntimer;
	private float timer = 0.0f;

	void Start()
	{
		spawntimer = Random.Range(3, 4);
	}

	void Update()
	{
		timer += Time.deltaTime;
		if (timer > spawntimer)
        	{
			spawntimer = Random.Range(3, 4);
			Clone = Instantiate(Object, transform.position, transform.rotation);
			timer = timer - spawntimer;
		}
		if (Clone && Input.GetKeyDown("a") && Object.name == "a") {
			Debug.Log("Precision: " + (Target.transform.position.y - Clone.transform.position.y));
			Destroy(Clone);
		}
		if (Clone && Input.GetKeyDown("s") && Object.name == "s") {
			Debug.Log("Precision: " + (Target.transform.position.y - Clone.transform.position.y));
			Destroy(Clone);
		}
		if (Clone && Input.GetKeyDown("d") && Object.name == "d") {
			Debug.Log("Precision: " + (Target.transform.position.y - Clone.transform.position.y));
			Destroy(Clone);
		}
		if (Clone && Clone.transform.position.y < -5)
			Destroy(Clone);
	}
}
