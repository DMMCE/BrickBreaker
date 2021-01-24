using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsKiller : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(collision.gameObject );
        }
         
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gift"))
        {
            Destroy(collision.gameObject);
        }
    }
}
