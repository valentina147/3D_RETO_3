using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weak : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (collision.gameObject.GetComponent<Rigidbody2D>().velocity.x, 20);
            Destroy(gameObject);
        }
    }
}
