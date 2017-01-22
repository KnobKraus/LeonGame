using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolloweControl : MonoBehaviour {
    public Rigidbody2D player;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //GetComponent<Rigidbody2D>().position = player.position;
        //GetComponent<Rigidbody2D>().rotation = 0;
        GetComponent<Transform>().position = new Vector3(player.position.x, player.position.y, 0);
        

    }
}
