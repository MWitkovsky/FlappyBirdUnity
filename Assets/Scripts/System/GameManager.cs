using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private static UIHandler ui;
    private static int score;
    private static bool gameActive;

    void Start()
    {
        ui = FindObjectOfType<UIHandler>();
        score = 0;
        gameActive = true;
    }

    public static void IncrementScore()
    {
        score++;
        ui.UpdateScoreDisplay();
    }

    public static int GetScore()
    {
        return score;
    }

    public static void SetGameActive (bool newState)
    {
        gameActive = newState;
        if (newState == false)
        {
            ui.ShowGameOver();
        }
    }

	public static bool IsGameActive()
    {
        return gameActive;
    }
}
