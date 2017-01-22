using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour {
    public int ms;
    bool dirRight;
    
    int frame;
    // Use this for initialization
    void Start () {
            dirRight = true;
           }
	
	// Update is called once per frame
	void Update () {
        frame = frame + 1;
        
       
		if (dirRight == true && frame<25)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(ms, 0);
            if (frame == 24)
            {
                dirRight = false;
                frame = 0;
            }
        }
        if(dirRight == false && frame<25)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-ms, 0);
            if (frame == 24)
            {
                dirRight = true;
                frame = 0;
            }
        }
    }


}
