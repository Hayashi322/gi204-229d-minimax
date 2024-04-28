using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    int jump;
    private Rigidbody2D body;
    private float horizontalInput;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed,  body.velocity.y);

        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);

        if (Input.GetButtonDown("Jump") && jump < 2)
            if (Input.GetButtonDown("Jump"))
            {
                jump++;
                body.velocity = new Vector2(body.velocity.x, 7f);
            }    
            
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        jump = 0;
    }

}
