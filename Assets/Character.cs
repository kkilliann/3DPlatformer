using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    float maxSpeed = 1.0f;
    float rotation = 0.0f;
    float camRotation = 0.0f;

    private CharacterController characterController;
    public float Speed = 5f;
    Rigidbody myRigidbody;

    bool isOnGround;
    public GameObject groundChecker;
    public LayerMask groundLayer;
    public float jumpForce = 300.0f;

    float rotationSpeed = 2.0f;
    float camRotationSpeed = 1.5f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);
        
        if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(transform.up * jumpForce);
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Vector3 newVelocity = transform.forward * Input.GetAxis("Vertical");
        myRigidbody.velocity = new Vector3(newVelocity.x, myRigidbody.velocity.y, newVelocity.z);

        characterController.Move(move * Time.deltaTime * Speed);
    
    }
}
