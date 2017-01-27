using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int movespeedBullet;
    private int frame;
    public bool pierced = false;

    // Use this for initialization
    void Start() {
        movespeedBullet = 5;
        Vector3 ps3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = new Vector2((ps3.x-GetComponent<Rigidbody2D>().position.x)*movespeedBullet, (ps3.y-GetComponent<Rigidbody2D>().position.y)*movespeedBullet);
        
        GetComponent<Rigidbody2D>().velocity = dir;


    }
	// Update is called once per frame
	void Update () {
        frame++;
      if (frame == 500)
        {
            Destroy(gameObject);
        }

	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Ground"))
        {
            Destroy(gameObject);
        }
        if (collision.name.Contains("Enemy"))
        {
            Destroy(collision.gameObject);
            if (pierced == false)
            Destroy(gameObject);
        }

    }
}
