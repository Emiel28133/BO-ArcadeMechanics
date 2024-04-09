using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinPickUp : MonoBehaviour
{
    private Renderer r;
    private keepScore scoreScript;
    private GameObject scoreObj;
    private AudioSource CoinSound;
    void Start()
    {
        CoinSound = GetComponent<AudioSource>();
        r = GetComponent<Renderer>();
        scoreObj = GameObject.FindWithTag("score");
        scoreScript = scoreObj.GetComponent<keepScore>();
        
    }
        
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CoinSound.Play();
            r.enabled = false;
            GameObject.Destroy(gameObject, 0.3f);
            scoreScript.AddScore(5);
        }
    }
}
