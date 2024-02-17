using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheat : MonoBehaviour
{
    public float jumpSpeed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector2.up * jumpSpeed * Time.deltaTime);
        }
    }
}
