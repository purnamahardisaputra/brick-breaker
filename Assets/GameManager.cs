using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Rigidbody2D rigidbodyBall;
    [SerializeField] float powerBall;
    private bool firstBall = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("log");
        if (other.gameObject.tag == "board" && firstBall == true)
        {
            rigidbodyBall.AddForce(transform.up * powerBall);
            Debug.Log("Enter");
            firstBall = false;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "brick")
        {
            GameObject brick = GameObject.FindWithTag("brick");
            Destroy(brick);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
