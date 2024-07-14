using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementVelocity : MonoBehaviour
{
    Vector2 move;
    [SerializeField] float speed;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        flip();
    }
    private void FixedUpdate()
    {
        rb.velocity = move * speed;
    }
    void flip()
    {
        if (move.x < -0.01f) transform.localScale = new Vector3(-1, 1, 1);
        if (move.x > 0.01f) transform.localScale = new Vector3(1, 1, 1);
    }
}
