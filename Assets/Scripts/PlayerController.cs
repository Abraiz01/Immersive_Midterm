using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    public float runSpeed;
    public float turnspeed;

    public float horizontalInput;
    public float verticalInput;

    public float jumpForce;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // getting player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        playerAnim.SetFloat("Speed_f", Math.Abs(verticalInput));

        // moving the dog forward on user input
        // playerRb.AddRelativeForce(Vector3.forward * runSpeed * verticalInput);
        if (verticalInput >= 0) {
            transform.Translate(Vector3.forward * runSpeed * Time.deltaTime * verticalInput);
        }
        
        // rotating the dog left/right on user input
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput); // Rotate(axis, angle)

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
