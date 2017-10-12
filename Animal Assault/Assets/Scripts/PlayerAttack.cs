using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public bool isP1;

    public bool attacking;

    float attackTimer = 0;
    public float attackOnTime;

    public Collider2D swordHitBox;

    // Use this for initialization
    void Awake()
    {
        swordHitBox.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && isP1 && !attacking || Input.GetKeyDown(KeyCode.RightControl) && !isP1 && !attacking)
        {
            attacking = true;
            attackTimer = attackOnTime;

            swordHitBox.enabled = true;
        }

        if (attacking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                swordHitBox.enabled = false;
            }

        }


    }
}
