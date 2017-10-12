using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour
{
    public bool isP1;

    public float damage;

    PlayerAttack pAttack;

    private void Awake()
    {
        pAttack = GetComponentInParent<PlayerAttack>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player2") && isP1 || col.CompareTag("Player1") && !isP1)
        {
            col.SendMessageUpwards("Damage", damage);

            if (isP1)
            {
                print("Hit Player2");
            }
            else
            {
                print("Hit Player1");
            }
        }
    }


    //void OnTriggerExit2D(Collider2D col)
    //{
    //    if (col.CompareTag("Player2"))
    //    {
    //        col.SendMessageUpwards("Damage", damage);
    //        print("Exit");
    //    }
    //}


    //void OnTriggerStay2D(Collider2D col)
    //{
    //    if (col.CompareTag("Player2"))
    //    {
    //        col.SendMessageUpwards("Damage", damage);
    //        print("Stay");
    //    }
    //}




}
