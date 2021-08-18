using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float scoreAmount;
    public float pointIncreasePerSecond;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        pointIncreasePerSecond = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE " + (int) scoreAmount;
        scoreAmount += pointIncreasePerSecond * Time.deltaTime;
    }
}