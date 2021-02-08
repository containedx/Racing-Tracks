using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 1.0f;

    public Rigidbody2D rigidBody;

    Vector2 moveVector;

    
    void Update()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + moveVector * speed * Time.deltaTime);
    }
}
