using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rd;

    // Start is called before the first frame update
    void Start()
    {
        rd.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        Destroy(gameObject);
    }
}
