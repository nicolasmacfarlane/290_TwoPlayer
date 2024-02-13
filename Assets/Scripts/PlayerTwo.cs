using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
public float speed = 7;
    public float rotationSpeed = 90;
    public float gravity = -15f;
    public float jumpSpeed = 10;
 
    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
 
    void Update()
    {
        float vInput = 0;
        float hInput = 0;

        if(Input.GetKey(KeyCode.I))
        {
            vInput = 1;
        }

        if(Input.GetKey(KeyCode.J))
        {
            hInput = -30;
        }

        else if(Input.GetKey(KeyCode.L))
        {
            hInput = 30;
        }

        if(characterController.isGrounded)
        {
            moveVelocity = transform.forward * speed * vInput;
            turnVelocity = transform.up * speed * hInput;

            if(Input.GetKeyDown(KeyCode.K))
            {
                moveVelocity.y = jumpSpeed;
            }
        }

        //Adding gravity
        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);
    }

}
