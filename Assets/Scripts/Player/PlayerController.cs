using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float fallSpeed = 5f;
    public float gravity = 9.81f;

    private Vector2 startPosition;
    private float currentFallSpeed = 0f;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        currentFallSpeed += gravity * Time.deltaTime;

        Vector2 newPosition = (Vector2)transform.position + Vector2.down * currentFallSpeed * Time.deltaTime;

        transform.position = newPosition;

        if (transform.position.y < -10f)
        {
            transform.position = startPosition;
            currentFallSpeed = 0f;
        }
    }
}
