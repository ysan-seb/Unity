using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float speed;

    void Start()
    {
	speed = Random.Range(-0.05f, -0.15f);        
    }

    void Update()
    {
	transform.Translate(0, speed, 0);
    }
}
