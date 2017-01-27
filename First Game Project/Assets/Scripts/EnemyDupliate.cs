using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDupliate : MonoBehaviour {

    int frame;
    int spawnFrame;
    public int spawnFrameInterval;
    // Use this for initialization
    void Start()
    {

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

       
        }
    }

