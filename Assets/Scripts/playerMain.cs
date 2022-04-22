using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerMain : MonoBehaviour
{
    public Bullet bulletPrefab;
    Rigidbody2D rb;
    public GameObject aimGuideline;
    [Range(1f, 15f)]
    public float thrustSpeed = 1f; // Default value is 1f
    public bool thrusting;
    [Range(-1f, 1f)]
    public float turnDirection = 0f; // Default value is 0f
    [Range(0f, 1f)]
    public float rotationSpeed = 0.1f; // Default value is 0.1f

    public float lives = 3f; // Default value is 3f



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); 
        aimGuideline = GameObject.Find("aimGuideline"); 
    }


    private void Update()
    {
        thrusting = Input.GetKey(KeyCode.W);

        if (Input.GetKey(KeyCode.A)) { 
            turnDirection = 1f; 
            Debug.Log("Turning left"); 
        } else if (Input.GetKey(KeyCode.D)) { 
            turnDirection = -1f; 
            Debug.Log("Turning right"); 
        } else {
            turnDirection = 0f; 
        }
        if (Input.GetKey(KeyCode.Mouse1)) // Right Click
        {
            aimGuideline.SetActive(true); 
            Debug.Log("Aim Guideline set to Active"); 
        } else {
            aimGuideline.SetActive(false); 
            Debug.Log("Aim Guideline set to Inactive"); 
        }
        if (Input.GetKeyDown(KeyCode.Mouse0)) { // Left Click 
            Shoot();
        } 
        if (Input.GetKeyDown(KeyCode.Escape)) { // Left Click 
            Quit();
        } 


    }

    private void FixedUpdate()
    {
        if (thrusting) {
            rb.AddForce(transform.up * thrustSpeed);
        }

        if (turnDirection != 0f) {
            rb.AddTorque(rotationSpeed * turnDirection);
        }
    }

    private void Shoot()
    {
        Bullet bullet = Instantiate(bulletPrefab, transform.position, transform.rotation); 
        bullet.bulletProjectile(transform.up); 
    }

    private void Quit()
    {
        Application.Quit();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == ("Asteroid")) {
            lives = lives - 1;
        }
    }
}


