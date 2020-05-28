using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    

    CharacterController controller;

    private Vector3 moveDirection = Vector3.zero;

    


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        controller = GetComponent<CharacterController>();
        controller.height = 2.0f;
    }

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        // is the controller on the ground?
        if (controller.isGrounded)
        {
            //Feed moveDirection with input.
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            //Multiply it by speed.
            moveDirection *= speed;
            //Jumping
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

            // Crouching
            if (Input.GetKey(KeyCode.C))
            {
                controller.height = 1.0f;
            }
            else
            {
                controller.height = 2.0f;
            }

            // Proning
            if(Input.GetKey(KeyCode.P))
            {
                
                moveDirection.y = moveDirection.y + 90;
                speed = 0f;
                jumpSpeed = 0f;
            }
            else
            {
                moveDirection.y = moveDirection.y - 90;
                speed = 6f;
                jumpSpeed = 8f;

            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                controller.height = 0.5f;
                speed = 3f;
            }
            else
            {
                controller.height = 2.0f;
                speed = 6f;
            }

        }
        //Applying gravity to the controller
        moveDirection.y -= gravity * Time.deltaTime;
        //Making the character move
        controller.Move(moveDirection * Time.deltaTime);
     }
    }