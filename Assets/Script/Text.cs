using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{

    [SerializeField]
    private TMP_Text scoreText;

    [SerializeField]
    private TMP_Text buttonText;

    public void showScore(string s)
    {
        scoreText.text = s;
    }

    public void showButton(string s)
    {
        buttonText.text = s;
    }
}
