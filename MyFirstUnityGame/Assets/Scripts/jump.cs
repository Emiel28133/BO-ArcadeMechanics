using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpAmount = 10;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
            //rb.velocity = rb.transform.forward * move;
            //Vector3 lastVel = rb.velocity;
            //Vector3 newVel = rb.transform.forward * move;
            //newVel.y = lastVel.y;
            //rb.velocity = newVel;
        }
    }
}
