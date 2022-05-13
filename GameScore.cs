using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameScore : MonoBehaviour
{
    public int[] scores;
    private int score;
    private TextMesh textObject;
    private GameObject klot;

    private int tries;
    private GameObject[] test;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        tries = 0;
        TextMesh textObject = GameObject.Find("ScoreText").GetComponent<TextMesh>();

    }

    // Update is called once per frame
    void Update()
    {
        TextMesh textObject = GameObject.Find("ScoreText").GetComponent<TextMesh>();

        textObject.text = score.ToString();
        
    }

    public void updateScore()
    {
        score++;
    }

    public void updateTries()
    {
        scores[tries] = score;
        score = 0;
        tries++;

        if (tries % 2 == 0)
        {
            test = GameObject.FindGameObjectsWithTag("Pin");
            foreach (GameObject t in test){
                t.GetComponent<Pinreset>().ResetPostion();
            }
        }
    }
}
