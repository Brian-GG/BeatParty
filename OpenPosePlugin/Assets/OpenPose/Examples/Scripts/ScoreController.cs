using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    public Text scoreMultiText;
    public int Score;
    public float scoreMulti;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        scoreMulti = 1.0f;
        scoreMultiText.text = "Score Multiplier: " + scoreMulti + "x";
        scoreText.text = "Score: 0";

    }

    // Update is called once per frame
    void Update()
    {
        scoreMultiText.text = "Score Multiplier: " + scoreMulti.ToString("F2", CultureInfo.InvariantCulture) + "x";
        scoreText.text = "Score: " + Score;
    }
}
