using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiercingShotScript : MonoBehaviour {
    bool triggered;
    public Bullet projektil;
    public PlayerController player;
	// Use this for initialization
	void Start () {
        triggered = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Leon" && triggered == false)
        {
            triggered = true;
            player.piercing = true;
            Destroy(gameObject);
               

        }

    }
}
