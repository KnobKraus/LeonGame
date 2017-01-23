using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour {
    public int ms;
    bool dirRight;
    
    int frame;
    public int frameMax;
    // Use this for initialization
    void Start () {
            dirRight = true;
        if (frameMax == 0)
        {
            frameMax = 24;
        }
            
        
           }
	
	// Update is called once per frame
	void Update () {
        frame = frame + 1;
        
       
		if (dirRight == true && frame<frameMax+1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(ms, 0);
            if (frame == frameMax)
            {
                dirRight = false;
                frame = 0;
            }
        }
        if(dirRight == false && frame<frameMax+1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-ms, 0);
            if (frame == frameMax)
            {
                dirRight = true;
                frame = 0;
            }
        }
    }


}
