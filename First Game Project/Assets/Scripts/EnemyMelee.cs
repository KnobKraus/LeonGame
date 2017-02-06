using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMelee : MonoBehaviour {
    public int frame;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (GetComponent<EnemyMovementAlt>().distanceToPlayer < GetComponent<Attributes>().meeleRange)
        {
            frame++;
            if (GetComponent<EnemyMovementAlt>().target.name == "Leon")
            {

                GetComponent<EnemyMovementAlt>().target.GetComponent<Attributes>().hitpoints -= GetComponent<Attributes>().meeleDamage;
            }
        }
	}
}
