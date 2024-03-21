using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinPickUp : MonoBehaviour
{
    private Renderer r;
    private keepScore scoreScript;
    private GameObject scoreObj;
    void Start()
    {  
        r = GetComponent<Renderer>();
        scoreObj = GameObject.FindWithTag("score");
        scoreScript = scoreObj.GetComponent<keepScore>();
        
    }
        
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            r.enabled = false;
            GameObject.Destroy(gameObject, 0.5f);
            scoreScript.AddScore(5);
        }
    }
}
