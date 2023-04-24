using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 moveInput;
    [SerializeField] private float speed;

    private const string Vertical = "Vertical";
    private const string Horizontal = "Horizontal";

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float vertical = Input.GetAxisRaw(Vertical);
        float horizontal = Input.GetAxisRaw(Horizontal);

        moveInput = new Vector2(horizontal, vertical).normalized;
    }
    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + moveInput * speed * Time.fixedDeltaTime);
    }

}//Class
