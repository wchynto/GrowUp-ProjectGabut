using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public PlayerCollision playerCollision;
    Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
    }

    private void Update()
    {
       if (playerCollision.foodIsDestroy == true)
        {
            scoreText.text = "SCORE : " + playerCollision.scorePoint.ToString();
        }
    }
}
