using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float PlayerSpeed;
    private Rigidbody2D rb;
    private Vector2 direction;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        direction = new Vector2(0, directionY).normalized;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, direction.y * PlayerSpeed);
    }
}