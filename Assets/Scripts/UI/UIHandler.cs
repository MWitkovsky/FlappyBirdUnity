using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

    public Text scoreDisplay;
    public Image gameOverDisplay;
	
	public void UpdateScoreDisplay()
    {
        scoreDisplay.text = "Score: " + GameManager.GetScore();
    }

    public void ShowGameOver()
    {
        gameOverDisplay.gameObject.SetActive(true);
    }
}
