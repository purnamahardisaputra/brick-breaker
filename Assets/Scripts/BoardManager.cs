using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour
{
    public GameObject Board;
    [SerializeField] float movementSpeed = 10f;
    public float force = 100f;
    public GameObject ball;
    private bool firstBall = false;

    // Start is called before the first frame update
    private void Awake()
    {
        Rigidbody2D rigidbodyBall = ball.GetComponent<Rigidbody2D>();
        rigidbodyBall.simulated = false;
    }
    IEnumerator waitBall()
    {
        Rigidbody2D rigidbodyBall = ball.GetComponent<Rigidbody2D>();
        yield return new WaitForSeconds(0.2f);
        rigidbodyBall.simulated = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && firstBall == true)
        {
            if (gameObject.transform.position.x <= 7.14f)
                transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) && firstBall == true)
        {
            if (gameObject.transform.position.x >= -7.14f)
                transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(waitBall());
            firstBall = true;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            GameObject bola = GameObject.FindWithTag("ball");
            if (bola.transform.position.x > Board.transform.position.x)
            {
                bola.GetComponent<Rigidbody2D>().AddForce(Vector2.left * force);
            }
            else
            {
                bola.GetComponent<Rigidbody2D>().AddForce(Vector2.right * force);
            }
        }
    }
}
