using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int scoreValue = 0;

    private bool isDead = false;
    public void GetScoreCount()
    {
        if (isDead)
            return;
        scoreValue += 1;
    }


    // Update is called once per frame
    void Update()
    {
        //if (isDead)
           //return;
        scoreText.text = scoreValue.ToString();
    }

    public void OnDeath()
    {
        isDead = true;
    }
}
