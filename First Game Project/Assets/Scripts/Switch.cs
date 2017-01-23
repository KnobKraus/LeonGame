using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
    public bool on = false;
    public Sprite Onsprite;
    public Sprite Offsprite;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Leon")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (on)
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = Offsprite;
                    on = false;
                }
                else
                {
                    gameObject.GetComponent<SpriteRenderer>().sprite = Onsprite;
                    on = true;
                }

            }
        }
    }
}
