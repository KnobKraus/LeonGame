using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Manager : MonoBehaviour {
    public MessageBox msg;
    public GameObject groundTrigger;
    bool triggerd;
	// Use this for initialization
	void Start () {
        triggerd = false;
        
    }
	
	// Update is called once per frame
	void Update () {
       if(triggerd == false && FindObjectsOfType<EnemyMovement>().Length < 2)
        {
            
            groundTrigger.GetComponent<Rigidbody2D>().gravityScale = 10;
            
            
            
        }
       if (FindObjectsOfType<EnemyMovement>().Length == 0)
        {
            msg.GetComponent<SpriteRenderer>().sprite = msg.winSprite;
}
	}
}
