using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouScoredTextController : MonoBehaviour
{
    public Text scoreText;
    private int score;

    void Start()
    {
        score = PlayerPrefs.GetInt("score");
        scoreText.text = "Congrats! You scored " + score + " points! That's a lot of fish!";
    }
}
