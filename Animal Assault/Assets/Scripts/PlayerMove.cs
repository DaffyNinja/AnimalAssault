using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public bool isP1;

    [Header("Move")]
    public float speed;
    public float jumpForce;

    public GameObject hitBox;
    public Transform groundCheck;

    [Header("Stats")]
    public float healthPoints;
    public Text playerHPText;
    
    Rigidbody2D rig;

    bool grounded;
    bool jump = false;

    [HideInInspector]
    public bool moveLeft;
    [HideInInspector]
    public bool moveRight;
    [HideInInspector]
    public bool lookUp;
    [HideInInspector]
    public bool lookDown;

    // Use this for initialization
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isP1)
        {
            playerHPText.text = "P1: " + healthPoints;
        }
        else
        {
            playerHPText.text = "P2: " + healthPoints;
        }

        // Move and Jump region
        #region 

        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        // Move
        if (moveLeft)  // Left
        {
            Vector2 moveQauntity = new Vector2(-speed, 0);
            rig.velocity = new Vector2(moveQauntity.x, rig.velocity.y);

            hitBox.transform.position = new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z);
        }
        if (moveRight) // Right
        {
            Vector2 moveQauntity = new Vector2(speed, 0);
            rig.velocity = new Vector2(moveQauntity.x, rig.velocity.y);

            hitBox.transform.position = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);
        }
        if (lookUp)  // Up
        {
            // Look Up
            hitBox.transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);

        }
        if (lookDown)  // Down
        {
            // Look Down
            hitBox.transform.position = new Vector3(transform.position.x, transform.position.y - 1f, transform.position.z);
        }


        //Jump

        //if (Input.GetKeyDown(KeyCode.Space) && grounded)
        //{
        //    rig.AddForce(new Vector2(0, jumpForce));
        //}

        #endregion

        // Health
        #region

        if (healthPoints <= 0)
        {
            print("DEAD!!");
        }

        #endregion
    }

    public void Damage(int damage)
    {
        healthPoints -= damage;
        
       // rig.AddForce(new Vector2(200, 60));
    }

}

