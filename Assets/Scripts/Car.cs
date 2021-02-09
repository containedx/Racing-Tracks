using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 5.0f;
    public float torque = -2.0f;

    public Rigidbody2D rigidBody;
    
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
        Debug.Log(collision.transform.name);
    }
}
