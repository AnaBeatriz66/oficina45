using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

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

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }
    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }
    public void teste(){
        
    }
    
    public void RestartGame( string lVLName)
    {
        SceneManager.LoadScene(lVLName);
    }
    
}
