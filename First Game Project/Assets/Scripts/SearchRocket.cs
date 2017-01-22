using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchRocket : MonoBehaviour {
    public Rigidbody2D player;
    public Vector2 vector;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        vector = new Vector2(player.position.x - GetComponent<Rigidbody2D>().position.x, player.position.y - GetComponent<Rigidbody2D>().position.y);
        GetComponent<Rigidbody2D>().velocity = vector; 
	}
}
