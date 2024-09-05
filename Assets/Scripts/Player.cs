using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontal; //Create float for left to right movement
    float horionztalSpeed = 5f; //Create the speed variable 
    public Rigidbody2D rb; //Reference to rigidbody2D
    public float currentHealth;
    private float lastVelocityChange = 0;
    public Burnbar burnbar;

     void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Get the rigidbody component
        currentHealth = 0;
        burnbar.setNotOnFire(0);

    }

    

    public void TakeDamage(float damage)
    {
        currentHealth += damage;
        burnbar.setNotOnFire(currentHealth);
    }

    // Update is called once per frame
    public void Update()

    {
        horizontal = Input.GetAxisRaw("Horizontal"); //Get the axis of Horizontal to move left and right
        Vector2 vector = new Vector2(horizontal, 0); //Create a new vector of just going left and right
        rb.velocity = vector * horionztalSpeed; //Multiply rigidbody with the vector and horionztalSpeed

        if (Time.time > lastVelocityChange + 0.2)
        {
            lastVelocityChange = Time.time;
            rb.velocity = vector * horionztalSpeed * Time.deltaTime;
            TakeDamage(1);
            
        }
        
        if (currentHealth == 20)
        {
            Destroy(gameObject);
        }
     }
  }




