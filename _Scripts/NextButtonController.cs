using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextButtonController : MonoBehaviour
{
    private Button nextButton;

    void Start()
    {
      nextButton = GetComponent<Button>();
      nextButton.gameObject.SetActive(false);
      Invoke("ShowNextButton", 1f);

    }

    public void NextButton()
    {
      SceneManager.LoadScene("Opening");
    }

    void ShowNextButton()
    {
        nextButton.gameObject.SetActive(true);
    }
}
