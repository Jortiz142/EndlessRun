using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] Text scoreText;
    public int score;
    public float scoreMultiplier = 1f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver == false)
        {
            scoreMultiplier = scoreMultiplier + .5f;
            score += Convert.ToInt32(Time.deltaTime * scoreMultiplier);
            UpdateText();
        }
    }

    public void UpdateText()
    {
        scoreText.text = ($"Score: {score}");
    }
}
