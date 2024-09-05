using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontal; //Create float for left to right movement
    [SerializeField] float horionztalSpeed; //Create the speed variable 
    public Rigidbody2D rb; //Reference to rigidbody2D

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Get the rigidbody component
    }
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); //Get the axis of Horizontal to move left and right

        Vector2 vector = new Vector2(horizontal, 0); //Create a new vector of just going left and right
        rb.velocity = vector * horionztalSpeed; //Multiply rigidbody with the vector and horionztalSpeed

    }
}
