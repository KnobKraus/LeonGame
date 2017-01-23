using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageBox : MonoBehaviour {

    public Sprite winSprite;
    public Sprite speedSprite;
    public Sprite jumpSprite;
    int frame;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (GetComponent<SpriteRenderer>().sprite != null)
        {
            frame++;
            if(frame == 75)
            {
                GetComponent<SpriteRenderer>().sprite = null;
                frame = 0;
            }
        }

       
        
        /*if ( == null)
        {
            transform.position = new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, 0);
            frame++;

            if (frame == 50)
            {
                transform.position = new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, -10);
                
                frame = 0;
            }
        }*/
		
	}
}
