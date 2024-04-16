using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedMult;
    public float moveSpeed;
    public Vector2 movementDirection;


    void FixedUpdate()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveSpeed = Mathf.Clamp(movementDirection.magnitude, 0.0f, 1.0f);
        movementDirection.Normalize();
        MovePlayer();
    }

    private void MovePlayer()
    {
        rb.velocity = movementDirection * moveSpeed * speedMult;
    }
}

