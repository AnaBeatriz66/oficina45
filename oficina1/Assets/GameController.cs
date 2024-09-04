using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    
    public int totalScore;
    public TMP_Text scoreText;

    public GameObject gameOver;
    public static GameController instance;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }
    
    public void ShowGameOver()
    {
        gameOver.setActive(true);
    }

    public void RestartGame();
    {

    }
}
