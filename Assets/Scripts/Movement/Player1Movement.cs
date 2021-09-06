using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    public float playerSpeed;
    public Rigidbody2D rigidbody2D;
    private Vector2 _playerDirection;

    // Update is called once per frame
    void Update()
    {
        float directionX;
        if (Input.GetKey(KeyCode.A)) directionX = -1f;
        else if (Input.GetKey(KeyCode.D)) directionX = 1f;
        else directionX = 0f;

        float directionY;
        if (Input.GetKey(KeyCode.S)) directionY = -1f;
        else if (Input.GetKey(KeyCode.W)) directionY = 1f;
        else directionY = 0f;

        _playerDirection = new Vector2(directionX, directionY).normalized;
    }

    void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(_playerDirection.x * playerSpeed, _playerDirection.y * playerSpeed);
    }
}
