using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour {

    public KeyCode flapKey;
    public KeyCode resetKey;

    private PlayerController playerController;
    private bool flapKeyPressed;

	// Use this for initialization
	void Start () {
        playerController = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(resetKey))
        {
            GameManager.ResetGame();
        }
        flapKeyPressed = Input.GetKeyDown(flapKey);
        playerController.ProcessInput(flapKeyPressed);
        ResetFlags();
	}

    private void ResetFlags()
    {
        flapKeyPressed = false;
    }
}
