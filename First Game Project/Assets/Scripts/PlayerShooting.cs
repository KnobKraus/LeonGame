using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {
    public GameObject projektil;
    bool shotRdy;
    public bool piercing;
    int shotFrame;
    public int shotInterval;
    // Use this for initialization
    void Start () {
        shotRdy = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (shotRdy == false)
        {
            shotFrame++;
            if (shotFrame == shotInterval)
            {
                shotRdy = true;
                shotFrame = 0;
            }
        }
        if (Input.GetKey(KeyCode.Mouse0) && shotRdy)
        {
            shotRdy = false;
            projektil.GetComponent<Rigidbody2D>().transform.position = GetComponent<Rigidbody2D>().transform.position;

            Instantiate(projektil);

            if (piercing == true)
                projektil.GetComponent<Bullet>().pierced = true;
            else
                projektil.GetComponent<Bullet>().pierced = false;
        }
    }
}
