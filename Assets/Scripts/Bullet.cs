using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    [Range(100, 1000)]
    public float speed = 500f; // Default is 500f
    [Range(1, 20)]
    public float maxLifetime = 3f; // Default is 3f

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    public void bulletProjectile(Vector2 direction)
    {
        rb.AddForce(direction * speed);  

        Destroy(gameObject, maxLifetime); 
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
