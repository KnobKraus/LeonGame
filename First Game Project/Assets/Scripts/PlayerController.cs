using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float moveSpeed;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    public CircleCollider2D reibung;

    private bool doubleJumped;
    public bool extraSpin;
    int frame;

    

	// Use this for initialization
	void Start () {

        reibung = GetComponent<CircleCollider2D>();
        extraSpin = false;
        
	}

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update () {

        if (grounded)
            doubleJumped = false;

        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jumped();
        }

        if (Input.GetKeyDown(KeyCode.Space) && !doubleJumped && !grounded)
        {
            Jumped();
            doubleJumped = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x*99/100, GetComponent<Rigidbody2D>().velocity.y);
        }
        if(extraSpin == true)
        {
            frame++;
            GetComponent<Rigidbody2D>().rotation = frame*100;
        }

        
    }

    public void Jumped()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Ground")
        {
            moveSpeed--;
        }

    }
}
