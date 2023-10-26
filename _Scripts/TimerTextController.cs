using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimerTextController : MonoBehaviour
{
    public float timeLeft;
    public bool timerOn = false;

    // public Text timerText;
    public Text timerText;

    void Start()
    {
      timerOn = true;
      // timerText = gameObject.GetComponent<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
          if (timeLeft > 0)
          {
            timeLeft -= Time.deltaTime;
            updateTimer(timeLeft);
          }
          else
          {
            Debug.Log("Time is up!");
            timeLeft = 0;
            timerOn = false;

            SceneManager.LoadScene("Ending");
          }

        }
    }
    void updateTimer(float currentTime)
    {
      currentTime += 1;
      float minutes = Mathf.FloorToInt(currentTime / 60);
      float seconds = Mathf.FloorToInt(currentTime % 60);
      timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
