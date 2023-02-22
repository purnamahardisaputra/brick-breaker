using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallManager : MonoBehaviour
{

    public Rigidbody2D rigidbodyBall;
    [SerializeField] float powerBall;
    private bool firstBall = true;
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
    }

    void OnCollisionExit2D(Collision2D other)
    {
        audioSource.Play();
    }


    // Update is called once per frame
    void Update()
    {

    }
}
