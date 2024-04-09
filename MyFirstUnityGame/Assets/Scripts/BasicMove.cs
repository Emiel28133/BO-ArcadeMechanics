using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasic : MonoBehaviour
{
    private float horiVal = 0f;
    //Maak 2 variabelen beschikbaar in de inspector
    [SerializeField] private float speed = 50f;

    //Maak een variabele voor je rigidbody
    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 positionUpdate = transform.position + Input.GetAxis("Horizontal") * transform.forward * speed * Time.deltaTime;
        horiVal = Input.GetAxis("Horizontal");
        //transform.position = positionUpdate;
        //transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0));
    }

    void FixedUpdate() 
    {
        MoveBackAndForth();
    }

    private void MoveBackAndForth()
    {
        Vector3 newVel = rb.velocity + transform.forward * speed * horiVal * Time.deltaTime;
        rb.velocity = newVel;

        if (horiVal == 0)
        {
            newVel = rb.velocity;
            newVel.x = 0f;
            newVel.z = 0f;
            rb.velocity = newVel;
        }
    }

}