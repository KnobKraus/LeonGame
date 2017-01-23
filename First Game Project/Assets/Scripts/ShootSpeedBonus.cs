using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSpeedBonus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name =="Leon")
        {
            collision.gameObject.GetComponent<PlayerController>().shootInterval = 2;
            Destroy(gameObject);
        }

    }
}
