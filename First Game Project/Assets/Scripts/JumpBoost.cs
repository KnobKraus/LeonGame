using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour {

    public PlayerController leon;
    bool triggered;
    public MessageBox messagebox;

    // Use this for initialization
    void Start()
    {
        triggered = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Leon" && triggered == false)
        {
            leon.jumpHeight = leon.jumpHeight * 2;
            triggered = true;
            messagebox.GetComponent<SpriteRenderer>().sprite = messagebox.jumpSprite;
            Destroy(gameObject);
        }

    }
}
