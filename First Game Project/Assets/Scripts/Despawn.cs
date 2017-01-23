using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour {
    public int maxFrames;
    int frames;
    public bool hasSwitch;
    public Switch schalter;


	// Use this for initialization
	void Start () {
   
	}
	
	// Update is called once per frame
	void Update () {
        if (hasSwitch == false) {
            frames += 1;
            if (frames == maxFrames)
                Destroy(gameObject); }
        else
        {
            if(schalter.on == true)
            {
                Destroy(gameObject);
            }
        }
	}
}
