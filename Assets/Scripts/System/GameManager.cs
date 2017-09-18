using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private static int score;
    private static bool gameActive;

    void Start()
    {
        score = 0;
        gameActive = true;
    }

    public static void IncrementScore()
    {
        score++;
    }

    public static int GetScore()
    {
        return score;
    }

    public static void SetGameActive (bool newState)
    {
        gameActive = newState;
    }

	public static bool IsGameActive()
    {
        return gameActive;
    }
}
