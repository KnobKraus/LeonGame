using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternateEnemyBullet : MonoBehaviour {
    public int lifeSpan;
    public Vector2 velo;
    int frame;
	// Use this for initialization
	void Start () {
        if (lifeSpan == 0)
            Destroy(gameObject);
        GetComponent<Rigidbody2D>().velocity = velo;
    }
        
	
	// Update is called once per frame
	void Update () {
        frame++;
        if (frame == lifeSpan)
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
        if (collision.name.Contains("Leon"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
}
