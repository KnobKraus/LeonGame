﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinBoost : MonoBehaviour {

    public PlayerController leon;
    bool triggered;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Leon" && triggered == false)
        {
            leon.extraSpin = true;
            triggered = true;
            Destroy(gameObject);
        }

    }
}
