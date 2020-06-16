using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rigidbody;
    public Animator animator;
    Vector2 lookDirection = new Vector2(1, 0);
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
       float horizontal = Input.GetAxisRaw("Horizontal");
       float vertical = Input.GetAxisRaw("Vertical");
       movement = new Vector2(horizontal, vertical);

        if(!Mathf.Approximately(movement.x, 0.0f)|| !Mathf.Approximately(0.0f, movement.y))
        {
            lookDirection.Set(movement.x, movement.y);
            lookDirection.Normalize();
        }

       animator.SetFloat("Horizontal", lookDirection.x);
       animator.SetFloat("Vertical", lookDirection.y);
       animator.SetFloat("Speed", movement.magnitude);
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
