using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    private int score;

    [SerializeField]
    private GameObject text;

    public int Score { get => score; set{ score = value; } }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Score == score)
        {
            text.GetComponent<Text>().showScore($"Score : {score}");
        }
        if(score >= 10)
        {
            text.GetComponent<Text>().showButton("You win!");
        }
    }
}
