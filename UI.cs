using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TMP_Text scoreText; 
    public scoremanage scoreManager;

    private void Update()
    {
        scoreText.text = "SCORE : " + scoreManager.score.ToString();
    }
}
