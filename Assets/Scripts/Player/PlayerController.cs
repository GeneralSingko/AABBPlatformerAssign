using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float fallSpeed = 5f;
    public float gravity = 9.81f;
    public float lerpSpeed = 0.1f;

    private Vector2 startPosition;
    private float currentFallSpeed = 0f;
    private Vector2 lastPosition;

    private void Start()
    {
        startPosition = transform.position;
        lastPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position.x != lastPosition.x)
        {
            // Reset the falling speed
            currentFallSpeed = 0f;
        }

        // Update the last recorded position
        lastPosition = transform.position;

        currentFallSpeed += gravity * Time.deltaTime;

        Vector2 newPosition = new Vector2(transform.position.x,transform.position.y - (currentFallSpeed * Time.deltaTime));

        Vector2 interpolatedPosition = Vector2.Lerp(transform.position, newPosition, lerpSpeed);

        transform.position = interpolatedPosition;

        if (transform.position.y < -10f)
        {
            transform.position = startPosition;
            currentFallSpeed = 0f;
        }
    }
}
