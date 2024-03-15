using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class keepScore : MonoBehaviour
{

    private TMP_Text scoreField;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreField.text = "" + score;
        scoreField = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    public void AddScore(int add)
    {
        score += add;
        scoreField.text = "" + score;
    }
}
