using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class brick : MonoBehaviour
{
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            Destroy(gameObject);
        }
    }
}
