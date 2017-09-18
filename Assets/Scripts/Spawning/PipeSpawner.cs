using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public GameObject pipes;
    public float yRange;
    public float spawnDelay;

    private float spawnTimer;

    void Start()
    {
        spawnTimer = spawnDelay;
    }
	
	void Update () {
        if (GameManager.IsGameActive())
        {
            spawnTimer -= Time.deltaTime;
            if (spawnTimer <= 0.0f)
            {
                Instantiate(pipes,
                    transform.position + Vector3.up * Random.Range(-yRange, yRange),
                    Quaternion.identity);
                spawnTimer = spawnDelay;
            }
        }   
	}
}
