using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weak2 : MonoBehaviour
{
    AudioSource m_AudioSource;
    public float salto = 3;
    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(collision.gameObject.GetComponent<Rigidbody2D>().velocity.x, salto);
            m_AudioSource.Play();
            Destroy(gameObject, 0.4f);
        }
    }
}
