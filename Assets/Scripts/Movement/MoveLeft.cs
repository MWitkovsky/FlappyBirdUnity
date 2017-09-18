using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

    public float moveSpeed;
	
	void FixedUpdate () {
        if (GameManager.IsGameActive())
        {
            transform.Translate(Vector3.left * moveSpeed * Time.fixedDeltaTime);
        }
	}
}
