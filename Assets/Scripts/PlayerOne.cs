using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
[RequireComponent(typeof(CharacterController))]
public class PlayerOne : MonoBehaviour
{
    public float speed = 7;
    public float rotationSpeed = 90;
    public float gravity = -5f;
    public float jumpSpeed = 30;
 
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

        if(Input.GetKey(KeyCode.W))
        {
            vInput = 1;
        }

        if(Input.GetKey(KeyCode.A))
        {
            hInput = -30;
        }

        else if(Input.GetKey(KeyCode.D))
        {
            hInput = 30;
        }

        if(characterController.isGrounded)
        {
            moveVelocity = transform.forward * speed * vInput;
            turnVelocity = transform.up * speed * hInput;

            if(Input.GetKeyDown(KeyCode.S))
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