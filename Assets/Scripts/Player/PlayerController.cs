using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravityScale = 9.8f;
    public float terminalVelocity = 10f;

    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        ApplyGravity();
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
