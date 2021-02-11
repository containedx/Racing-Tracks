using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed = 5.0f;
    public float torque = -2.0f;

    public Rigidbody2D rigidBody;

    public TimeCounter time;
    bool started = false;

    public GameObject FinishLine;
    public bool finish = false;
    
    void FixedUpdate()
    {
        //going forward movement
        if (Input.GetKey(KeyCode.W))
        {
            rigidBody.AddForce(transform.up * speed);
        }
        rigidBody.velocity = transform.up * Vector2.Dot(rigidBody.velocity, transform.up);

        if (Input.GetKey(KeyCode.S))
        {
            rigidBody.AddForce(transform.up * speed/2 *-1);
        }

        //rotation movement
        rigidBody.AddTorque( Input.GetAxis("Horizontal") * torque);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.transform.name); 

        if(collision.transform.name == "Tile" && !started)
        {
            time.StartTimer();
            started = true;
        }
        if(collision.transform.name == "Halfway")
        {
            FinishLine.gameObject.SetActive(true);
        }
        if (collision.transform.name == "Finish")
        {
            finish = true;
            double value = time.MeasureTime();
        }
    }
}
