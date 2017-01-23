using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDupliate : MonoBehaviour {

    public int ms;
    bool dirRight;

    int frame;
    public int frameMax;
    int spawnFrame;
    public int spawnFrameInterval;
    // Use this for initialization
    void Start()
    {
        dirRight = true;
        if (frameMax == 0)
        {
            frameMax = 24;
        }
        spawnFrameInterval = 200;


    }

    // Update is called once per frame
    void Update()
    {
        frame++;

        if(spawnFrameInterval != 0 && FindObjectsOfType<EnemyDupliate>().Length < 150)
        spawnFrame++;

        if (spawnFrame == spawnFrameInterval)
        {
            Instantiate(gameObject);
            spawnFrame = 0;
        }

        if (dirRight == true && frame < frameMax + 1)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(ms, 0);
            if (frame == frameMax)
            {
                dirRight = false;
                frame = 0;
            }
        }
        if (dirRight == false && frame < frameMax + 1)
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
