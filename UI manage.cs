using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanage : MonoBehaviour
{
    public Button playButton;
    public Button exit;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exit.onClick.AddListener(Exit);

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("pinball");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
