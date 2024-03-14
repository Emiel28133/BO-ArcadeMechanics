using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Example : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;
    public float gravityScale = 5;
    private bool onFloor = false;
    

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
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
        if (Input.GetButton("Jump"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
           // m_Rigidbody.AddForce(transform.up * m_Thrust);
           // m_Rigidbody.AddForce(Physics.gravity * (gravityScale - 1) * m_Rigidbody.mass);
            if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
            {
                m_Rigidbody.AddForce(transform.up * m_Thrust);
                m_Rigidbody.AddForce(Physics.gravity * (gravityScale - 1) * m_Rigidbody.mass);
            }
        }
    }
}

