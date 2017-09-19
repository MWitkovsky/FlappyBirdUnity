using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float flapForce;

    private Rigidbody2D rb;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	public void ProcessInput(bool flapKey)
    {
        if (GameManager.IsGameActive())
        {
            if (flapKey)
            {
                rb.velocity = Vector2.up * flapForce;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (GameManager.IsGameActive())
        {
            if (other.CompareTag("Pipe") || other.CompareTag("Ground"))
            {
                GameManager.SetGameActive(false);
            }
            else if (other.CompareTag("ScoreBox"))
            {
                GameManager.IncrementScore();
            }
        }
    }
}
