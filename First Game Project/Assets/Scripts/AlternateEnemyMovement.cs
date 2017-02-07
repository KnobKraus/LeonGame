using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

    public class AlternateEnemyMovement : MonoBehaviour
    {
    public Transform target;
    public float moveSpeed;
    public float accuracy;
    double zahl1, zahl2;
    Vector2 randTarget, direction;
    float dist;
    int frameCount;
    System.Random rand;
        // Use this for initialization
        void Start()
        {
        
        rand = new System.Random();
        }

        // Update is called once per frame
        void Update()
        {
        frameCount += 1;
            if (frameCount == 10)
            {
                frameCount = 0;
                if (target == null)
                {
     
                }
                zahl1 = rand.Next(Mathf.RoundToInt(target.position.x - accuracy), Mathf.RoundToInt(target.position.x + accuracy)) + rand.NextDouble();
                zahl2 = rand.Next(Mathf.RoundToInt(target.position.y - accuracy), Mathf.RoundToInt(target.position.y + accuracy)) + rand.NextDouble();
                randTarget = new Vector2((float)zahl1, (float)zahl2);
                direction = randTarget - GetComponent<Rigidbody2D>().position;
                dist = Mathf.Sqrt(direction.x * direction.x + direction.y * direction.y);
                GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x * moveSpeed / dist, direction.y * moveSpeed / dist);
            }

        }
    }
