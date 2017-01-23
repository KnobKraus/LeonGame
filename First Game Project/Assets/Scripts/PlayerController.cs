using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float moveSpeed;
    public float jumpHeight;

    public Slider slider;  
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;
    public CircleCollider2D reibung;
    public int shootInterval;
    private bool doubleJumped;
    public bool extraSpin;
    int frame;
    public GameObject projektil;
    private bool shotRdy;
    int shotFrame;
    public bool piercing;

	// Use this for initialization
	void Start () {

        reibung = GetComponent<CircleCollider2D>();
        extraSpin = false;
        shotRdy = true;
        shotFrame = 0;
        shootInterval = 20;
        piercing = false;
	}

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update () {
        try
        {
            GetComponent<Rigidbody2D>().gravityScale = slider.GetComponent<Slider>().value / 100;
        }catch(Exception e) { }
        {

        }
        if (shotRdy == false)
        {
            shotFrame++;
            if (shotFrame == shootInterval)
            {
                shotRdy = true;
                shotFrame = 0;
            }
        }

        if (grounded)
            doubleJumped = false;
        try
        {
            if (Input.GetKey(KeyCode.W))
            {
                slider.GetComponent<Slider>().value = slider.GetComponent<Slider>().value - 3;
            }

            if (Input.GetKey(KeyCode.S))
            {
                slider.GetComponent<Slider>().value = slider.GetComponent<Slider>().value + 3;
            }
        }
        catch { }
        if (Input.GetKey(KeyCode.Mouse0) && shotRdy)
        {
            shotRdy = false;
            projektil.GetComponent<Rigidbody2D>().transform.position = GetComponent<Rigidbody2D>().transform.position;
            
            Instantiate(projektil);

            if (piercing == true) 
                projektil.GetComponent<Bullet>().pierced = true;
            else
                projektil.GetComponent<Bullet>().pierced = false;



            //projektil.GetComponent<Rigidbody2D>().velocity = new Vector2((Input.mousePosition.x - GetComponent<Rigidbody2D>().position.x)*projektil.GetComponent<Bullet>().movespeedBullet, (Input.mousePosition.x - GetComponent<Rigidbody2D>().position.x)* projektil.GetComponent<Bullet>().movespeedBullet);       }
        }
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
        else
        {
            frame = 0;
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
