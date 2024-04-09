using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class fallDeth : MonoBehaviour
{
    [SerializeField] GameObject A;
    private Heart lives;  // Reference to the Heart class instance

    void Start()
    {
        // Get the Heart component from the Canvas
        lives = FindObjectOfType<Heart>();
        if (lives == null)
        {
            Debug.LogError("Heart component not found in the scene.");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "floor")
        {
            Debug.Log("Player collided with floor.");

            if (lives != null)
            {
                lives.Lives--; // Decrease lives in the Heart script
                transform.position = A.transform.position;
            }

            

            if (lives != null && lives.Lives <= 0)
            {
                Debug.Log("Player has no lives left. Destroying player object.");
                Destroy(gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
    }
}
