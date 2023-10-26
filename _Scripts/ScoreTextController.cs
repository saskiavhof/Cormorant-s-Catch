using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextController : MonoBehaviour
{
    public Text scoreText;
    public int score;
    //int highscore = 0;

    void Start()
    {
        score = 0;
        scoreText.text = "SCORE: " + score;
        //highscoreText.text = "HIGHSCORE: " + highscore.ToString();

    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
     {
         if (collision.gameObject.tag == "bigFish")
         {
           score += 1; //up by 1
           //Destroy(collision.gameObject);
           collision.gameObject.SetActive(false);
           scoreText.text = "SCORE: " + score;

         }

         if (collision.gameObject.tag == "smallFish")
         {
           score += 0;
           //Destroy(collision.gameObject);
           collision.gameObject.SetActive(false);
           scoreText.text = "SCORE: " + score;

         }
         if (collision.gameObject.tag == "notFish")
         {
           score -= 1;
           //Destroy(collision.gameObject);
           collision.gameObject.SetActive(false);
           scoreText.text = "SCORE: " + score;
         }

         PlayerPrefs.SetInt("score", score);
     }
}
