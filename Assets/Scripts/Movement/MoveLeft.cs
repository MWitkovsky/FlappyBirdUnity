using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

    public float moveSpeed;
	
	void Update () {
        if (GameManager.IsGameActive())
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
	}
}
