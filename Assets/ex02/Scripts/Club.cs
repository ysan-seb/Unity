using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour
{
    private Ball Ball;
    public GameObject ball;
    private float origin = 0.0f;
    private float velocity = 0.0f;
    public static bool action = false;

    void Update()
    {
        if (Input.GetKey("space") && Ball.speed == 0 && Ball.end == false) {
            if (origin < 0.15f) {
                velocity += 1f;
                origin += 0.01f;
                transform.Translate(0, -0.08f, 0);
            }
        }
        else {
            if (origin > 0.00f) {
                transform.Translate(0, 0.16f, 0);
                origin -= 0.02f;
            }
            if (Ball.speed == 0) {
                transform.position = new Vector3(-0.2f, ball.transform.position.y, 0);
                Ball.speed = velocity;
                Ball.direction = 1;
                velocity = 0;
            }
        }
    }
}
