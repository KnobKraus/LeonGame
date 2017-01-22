using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour {
     
    public PlayerController leon;
    bool triggered;
    public MessageBox messageBox;

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
            leon.moveSpeed = leon.moveSpeed * 2;
            triggered = true;
            messageBox.GetComponent<SpriteRenderer>().sprite = messageBox.speedSprite;
            Destroy(gameObject);
            
        }

    }
}
