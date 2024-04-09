using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keepScore : MonoBehaviour
{

    private TMP_Text scoreField;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreField = GetComponent<TMP_Text>();
        scoreField.text = " " + score;
    }

    public void AddScore(int add)
    {
        score += add;
        scoreField.text = " " + score;

        if (score >= 20) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
