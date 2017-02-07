using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRangedAttack : MonoBehaviour {
    public int shotInterval;
    public int projectileLifeSpan;
    public GameObject projektil;
    public string mode;
    public GameObject target;
    public float projectileSpeed;
    Vector2 direction;

    int frame;
	// Use this for initialization
	void Start () {
		if (mode == string.Empty)
        {
            mode = "aim";
        }
	}
	
	// Update is called once per frame
	void Update () {
        frame++;
        if (frame == shotInterval) {
            if (mode == "aim")
            {
                direction.x = target.GetComponent<Rigidbody2D>().position.x - GetComponent<Rigidbody2D>().position.x;
                direction.y = target.GetComponent<Rigidbody2D>().position.y - GetComponent<Rigidbody2D>().position.y;
            }
            direction.Normalize();
            projektil.transform.position = GetComponent<Transform>().position;
            projektil.GetComponent<AlternateEnemyBullet>().lifeSpan = projectileLifeSpan;
            projektil.GetComponent<AlternateEnemyBullet>().velo = direction * projectileSpeed;
            Instantiate(projektil);
            print(direction * projectileSpeed);
            frame = 0;
        }
    }
    }

