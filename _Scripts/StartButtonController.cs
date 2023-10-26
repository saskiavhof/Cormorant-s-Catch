using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonController : MonoBehaviour
{
    private Button startButton;

    void Start()
    {
      startButton = GetComponent<Button>();
      startButton.gameObject.SetActive(false);
      Invoke("ShowStartButton", 8.8f);

    }

    public void StartButton()
    {
      SceneManager.LoadScene("Game");
    }

    void ShowStartButton()
    {
        startButton.gameObject.SetActive(true);
    }
}
