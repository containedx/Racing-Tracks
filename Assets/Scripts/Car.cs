using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 5.0f;
    public float torque = -2.0f;

    public Rigidbody2D rigidBody;

    // how many times player passed through Tile
    int passCount = 0;
    public TimeCounter time;
    
    void FixedUpdate()
    {
        //going forward movement
        if (Input.GetKeyDown(KeyCode.W))
        {
            rigidBody.AddForce(transform.up * speed);
        }
        rigidBody.velocity = transform.up * Vector2.Dot(rigidBody.velocity, transform.up);

        if (Input.GetKeyDown(KeyCode.S))
        {
            rigidBody.AddForce(transform.up * speed/2 *-1);
        }

        //rotation movement
        rigidBody.AddTorque( Input.GetAxis("Horizontal") * torque);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        passCount += 1; //1-start 2-finish
        Debug.Log(collision.transform.name + passCount); 

        if(passCount == 1)
        {
            time.StartTimer();
        }
    }
}
