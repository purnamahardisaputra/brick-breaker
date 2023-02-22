using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    [SerializeField] private GameManager score;

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            var go = gameObject.name;
            if (go == gameObject.name)
            {
                Destroy(gameObject);
                score.score += Random.Range(1, 5);
            }
        }
    }
}
