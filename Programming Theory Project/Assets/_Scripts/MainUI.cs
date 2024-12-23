using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    
    public Text scoreText;
    int score = 0;
    private void Awake()
    {
        
        scoreText.text = "Goal: Get the 7 balls around the map (0/7).";
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void UpdateScore()
    {
        score += 1;
        scoreText.text = "Goal: Get the 7 balls around the map ("+score+"/7).";
    }
}
