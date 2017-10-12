using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "PlayerAttackHitBox")
        {
            print("HIT");
        }
    }


    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.name == "PlayerAttackHitBox")
        {
            print("HIT");
        }
    }

}
