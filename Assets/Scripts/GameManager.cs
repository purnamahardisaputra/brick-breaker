using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    public int score = 0;
    [SerializeField] private GameObject brickEnemy;
    private int brickTotal;
    private bool isWin = false;
    private bool isGameOver = false;
    [SerializeField] private GameObject gameOverPanel;
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        brickTotal = brickEnemy.transform.childCount;
        if (brickTotal == 0 && isWin == false)
        {
            Debug.Log("You Win");
            isWin = true;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "floor")
        {

        }
    }
}
