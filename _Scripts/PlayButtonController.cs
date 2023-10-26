using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButtonController : MonoBehaviour
{
    private Button playButton;

    void Start()
    {
      playButton = GetComponent<Button>();
      playButton.gameObject.SetActive(false);
      Invoke("ShowPlayButton", 2f);

    }

    public void PlayButton()
    {
      SceneManager.LoadScene("Gifu2");
    }

    void ShowPlayButton()
    {
        playButton.gameObject.SetActive(true);
    }
}
