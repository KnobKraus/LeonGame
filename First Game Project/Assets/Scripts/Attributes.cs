using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour {
    public int level;
    public int hitpoints;
    public float moveSpeed;
    public int mana;
    public bool armored;
    public int meeleDamage;
    public int meeleRange;
    public int attackInterval;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hitpoints <= 0){
            Destroy(gameObject);
        }
	}
}
