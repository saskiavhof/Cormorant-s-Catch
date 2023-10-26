using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HowToPlayButtonController : MonoBehaviour
{
    private Button howToPlayButton;

    void Start()
    {
      howToPlayButton = GetComponent<Button>();
      howToPlayButton.gameObject.SetActive(false);
      Invoke("ShowHowToPlayButton", 1f);

    }

    public void HowToPlayButton()
    {
      SceneManager.LoadScene("Gifu3");
    }

    void ShowHowToPlayButton()
    {
        howToPlayButton.gameObject.SetActive(true);
    }
}
