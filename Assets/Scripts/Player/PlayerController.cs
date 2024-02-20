using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravityScale = 9.8f;
    public float terminalVelocity = 10f;

    private Vector3 velocity = Vector3.zero;

    public float jumpForce = 5f;

    CollisionManager cM;

    void Update()
    {
        ApplyGravity();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Move the object upward
            Jump();
        }
    }

    void Jump()
    {
        Vector3 currentPosition = transform.position;

        Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y + jumpForce, currentPosition.z);

        transform.position = newPosition;
    }

    void ApplyGravity()
    {
        // Calculate gravity
        velocity.y -= gravityScale * Time.deltaTime;

        // Limit the falling speed to terminal velocity
        velocity.y = Mathf.Clamp(velocity.y, -terminalVelocity, terminalVelocity);

        // Update the position using calculated velocity
        transform.position += velocity * Time.deltaTime;
    }
}
