using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public bool isKeyboard;

    public bool isx360Control;

    //public bool moveLeft;
    //public bool moveRight;
    //public bool lookUp;
    //public bool lookDown;

    bool isP1;
    PlayerMove pMove;

    // Use this for initialization
    void Awake()
    {
        pMove = GetComponent<PlayerMove>();

        isP1 = pMove.isP1;

    }

    // Update is called once per frame
    void Update()
    {
        if (isKeyboard == false)
        {
            if (isx360Control)
            {
                if (Input.GetAxis("X360LeftStick") > 0)
                {
                    print("Right");
                    pMove.moveRight = true;
                }
                else if (Input.GetAxis("X360LeftStick") < -0.1f)
                {
                    print("Left");
                    pMove.moveLeft = true;
                }
                else
                {
                    pMove.moveLeft = false;
                    pMove.moveRight = false;
                }
                       



            }

        }
        else
        {
            if (Input.GetKey(KeyCode.A) && isP1 || Input.GetKey(KeyCode.LeftArrow) && !isP1)  // Left
            {
                pMove.moveLeft = true;
            }
            else if (Input.GetKeyUp(KeyCode.A) && isP1 || Input.GetKey(KeyCode.LeftArrow) && !isP1)
            {
                pMove.moveLeft = false;
            }

            if (Input.GetKey(KeyCode.D) && isP1 || Input.GetKey(KeyCode.RightArrow) && !isP1) // Right
            {
                pMove.moveRight = true;
            }
            else if (Input.GetKeyUp(KeyCode.D) && isP1 || Input.GetKey(KeyCode.RightArrow) && !isP1) // Right
            {
                pMove.moveRight = false;
            }

            if (Input.GetKey(KeyCode.W) && isP1 || Input.GetKey(KeyCode.UpArrow) && !isP1)  // Up
            {
                // Look Up
                pMove.lookUp = true;
            }
            else if (Input.GetKeyUp(KeyCode.W) && isP1 || Input.GetKey(KeyCode.UpArrow) && !isP1)
            {
                pMove.lookUp = false;
            }

            if (Input.GetKey(KeyCode.S) && isP1 || Input.GetKey(KeyCode.DownArrow) && !isP1)  // Down
            {
                // Look Down
                pMove.lookDown = true;
            }
            else if (Input.GetKeyUp(KeyCode.S) && isP1 || Input.GetKey(KeyCode.DownArrow) && !isP1)
            {
                pMove.lookDown = false;
            }



        }

    }
}
