using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Example : MonoBehaviour
{
    Rigidbody rb;
    public float m_Thrust = 1f;
    private float gravityScale = 1f;
    private bool onFloor = false;
    public float gravScaleUp = 2f; // Define the gravity scale when going up
    public float gravScaleDown = 0.5f; // Define the gravity scale when going down


    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        rb = GetComponent<Rigidbody>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            onFloor = true;
        }

        //if (Input.GetKeyDown(KeyCode.Space) && onFloor == true) ;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            onFloor = false;
        }

        //if (Input.GetKeyDown(KeyCode.Space) && onFloor == true) ;
    }


    void Update()
    {

        if (rb.velocity.y > 0)
        {
            gravityScale = gravScaleUp;
        }
        else if (rb.velocity.y < 0)
        {
            gravityScale = gravScaleDown;
        }

        if (Input.GetButton("Jump"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
           // m_Rigidbody.AddForce(transform.up * m_Thrust);
           // m_Rigidbody.AddForce(Physics.gravity * (gravityScale - 1) * m_Rigidbody.mass);
            if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
            {
                rb.AddForce(transform.up * m_Thrust);
                rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);

            }

        }


    }
}

