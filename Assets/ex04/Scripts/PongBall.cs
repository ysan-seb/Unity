using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour {

	public GameObject Player1;
    private int scorePlayer1 = 0;
    public GameObject Player2;
    private int scorePlayer2 = 0;
    public GameObject Ball;

	private bool inGame = false;
	private Vector3 originBall;
	private float vectorX;
    private float vectorY;

	void Start () {
		originBall = Ball.transform.position;
        vectorX = Random.Range(-1f, 1f);
        vectorX = vectorX > 0 ? 0.1f : -0.1f;
        vectorY = Random.Range(-1f, 1f);
        vectorY = vectorY > 0 ? 0.1f : -0.1f;
    }
	
	void Update () {
		Ball.transform.Translate(vectorX, vectorY, 0);
		if (inGame == false) {
			inGame = true;
			Ball.transform.position = originBall;
            vectorX = Random.Range(-1f, 1f);
            vectorX = vectorX > 0 ? 0.1f : -0.1f; 
            vectorY = Random.Range(-1f, 1f);
            vectorY = vectorY > 0 ? 0.1f : -0.1f;
        }
        if ((Ball.transform.position.x < Player1.transform.position.x + Player1.transform.localScale.x / 2
            && Ball.transform.position.x > Player1.transform.position.x - Player1.transform.localScale.x / 2
            && Ball.transform.position.y < Player1.transform.position.y + Player1.transform.localScale.y / 2
            && Ball.transform.position.y > Player1.transform.position.y - Player1.transform.localScale.y / 2))
            vectorX = -vectorX;
        else if ((Ball.transform.position.x > Player2.transform.position.x - Player2.transform.localScale.x / 2
            && Ball.transform.position.x < Player2.transform.position.x + Player2.transform.localScale.x / 2
            && Ball.transform.position.y < Player2.transform.position.y + Player2.transform.localScale.y / 2
            && Ball.transform.position.y > Player2.transform.position.y - Player2.transform.localScale.y / 2))
            vectorX = -vectorX;
        if (Ball.transform.position.x > 7f)
        {
            inGame = false;
            scorePlayer1 += 1;
            Debug.Log("Player 1: " + scorePlayer1 + " | Player 2: " + scorePlayer2);
        }
        if (Ball.transform.position.x < -7f)
        {
            inGame = false;
            scorePlayer2 += 1;
            Debug.Log("Player 1: " + scorePlayer1 + " | Player 2: " + scorePlayer2);
        }
        if (Ball.transform.position.y > 4.5f || Ball.transform.position.y < -4.5f)
            vectorY = -vectorY;
    }
}
