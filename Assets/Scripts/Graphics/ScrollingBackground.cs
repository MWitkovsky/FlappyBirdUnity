using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

    public float speed;

    private Renderer rend;
    private float position;

    void Start ()
    {
        rend = GetComponent<Renderer>();
    }

    void Update () {
        if (GameManager.IsGameActive())
        {
            position += speed * Time.deltaTime;
            if (position > 1.0f)
            {
                position -= 1.0f;
            }

            rend.material.mainTextureOffset = new Vector2(position, 0.0f);
        }
	}
}
