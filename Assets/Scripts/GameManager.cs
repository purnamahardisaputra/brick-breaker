using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text scoreLose;
    [SerializeField] private TMP_Text scoreWin;
    public int score = 0;
    [SerializeField] private GameObject brickEnemy;
    private int brickTotal;
    public bool isWin = false;
    public bool isGameOver = false;
    public GameObject ball;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject gameWinPanel;
    [SerializeField] private string nextLevelName;
    
    
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        scoreWin.text = "Score: " + score;
        scoreLose.text = "Score: " + score;
        brickTotal = brickEnemy.transform.childCount;
        
        // game win
        if (brickTotal == 0 && isWin == false)
        {
            Debug.Log("You Win");
            gameWinPanel.SetActive(true);
            isWin = true;
            ball.SetActive(false);
        }

        // game lose
        if(isGameOver == true)
        {
            Debug.Log("Game Over");
            gameOverPanel.SetActive(true);
            isGameOver = false;
            ball.SetActive(false);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void nextLevels()
    {
        SceneManager.LoadScene(nextLevelName);
    }
}
