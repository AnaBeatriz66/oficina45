using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    
    public int totalScore;
    public TMP_Text scoreText;
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
    
}
