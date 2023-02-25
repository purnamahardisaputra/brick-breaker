using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallManager : MonoBehaviour
{

    public Rigidbody2D rigidbodyBall;
    [SerializeField] float powerBall;
    private bool firstBall = true;
    public GameManager gameManager;
    [SerializeField] AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "board" && firstBall == true)
        {
            rigidbodyBall.AddForce(transform.up * powerBall);
            Debug.Log("First Ball");
            firstBall = false;
        }
        if (other.gameObject.tag == "floor" && gameManager.isGameOver == false)
        {
            gameManager.isGameOver = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "board" || other.gameObject.tag == "brick" || other.gameObject.tag == "wall")
        {
            audioSource.Play();
        }
        
    }


    // Update is called once per frame
    void Update()
    {

    }
}
