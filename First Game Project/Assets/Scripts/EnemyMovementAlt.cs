using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMovementAlt : MonoBehaviour {
    public int inaccuracy;
    public GameObject target;
    public GameObject player;
    private System.Random rnd;
    private Vector2 point;
    private Vector2 dir;
    private int frame;
    public float moveSpeed;
    public float aggroRange;
    public bool isPulled;
    public float distanceToPlayer;
	// Use this for initialization
	void Start () {
        rnd = new System.Random();
        inaccuracy = 5;
        isPulled = false;
	}
	
	// Update is called once per frame
	void Update () {
        frame++;
        if (frame == 50)
        {
            point = new Vector2(target.transform.position.x + rnd.Next(-inaccuracy, inaccuracy), target.transform.position.y + rnd.Next(-inaccuracy, inaccuracy));
            dir = point - (Vector2)GetComponent<Transform>().position;
            frame = 0;
            dir.Normalize();
            GetComponent<Rigidbody2D>().velocity = moveSpeed * dir;
        }
        distanceToPlayer = ((Vector2)player.GetComponent<Transform>().position - (Vector2)GetComponent<Transform>().position).magnitude;
        if (distanceToPlayer < aggroRange && isPulled==false)
        {
            target = player;
            inaccuracy = 0;
            isPulled = true;
        }
    }
}
