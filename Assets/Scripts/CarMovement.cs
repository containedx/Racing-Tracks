using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float torque = -2.0f;

    public Rigidbody2D rigidBody;
    
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //going forward movement
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up");
            rigidBody.AddForce(transform.right * speed);
        }

        //rotation movement
        rigidBody.AddTorque( Input.GetAxis("Horizontal") * torque);
    }
}
