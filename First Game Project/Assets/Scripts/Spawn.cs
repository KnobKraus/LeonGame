using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public int maxFrames;
    int frames;
    public bool hasSwitch;
    public Switch schalter;


    // Use this for initialization
    void Start()
    {
    gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasSwitch == false)
        {
            frames += 1;
            if (frames == maxFrames)
                gameObject.SetActive(true);
        }
        else
        {
            if (schalter.on == true)
            {
                gameObject.SetActive(true);
            }
        }
    }
}
