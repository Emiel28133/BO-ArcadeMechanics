using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    private Rigidbody rb;
    private bool onFloor = false;
    private bool isJumping = false;
    private float gravityScale = 1f;

    [SerializeField] private float jumpGravityScale = 1f;
    [SerializeField] private float fallGravityScale = 1f;

    [SerializeField] private float jumpForce = 15f;


    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        rb = GetComponent<Rigidbody>();

    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space) && onFloor)
        {
            isJumping = true;
        }
    }

    void FixedUpdate() 
    {
        if (isJumping) 
        {
            isJumping = false;
            onFloor = false;
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }

        if (rb.velocity.y < 0)
        {
            gravityScale = fallGravityScale;
        }
        else if (rb.velocity.y > 0)
        {
            gravityScale = jumpGravityScale;
        }

        rb.AddForce((gravityScale - 1) * Physics.gravity * rb.mass);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            onFloor = true;
        }
        else
        {

        }
    }

    
}

