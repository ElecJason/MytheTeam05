using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private IEnumerator coroutine;
    private int Score = 00;
    [SerializeField] private Text scoreDisplay;
    [SerializeField] private float seconds;
    [SerializeField] private float minutes;

    void Start()
    {
        scoreDisplay = GetComponent<Text>();
        coroutine = WaitAndPrint(1.0f);
        StartCoroutine(coroutine);
    }

    private void Update()
    {
        if(Score < 10)
        {
            scoreDisplay.text = "Time: " + minutes + ":0" + seconds.ToString();
        }
        else
        {
            scoreDisplay.text = "Time: " + minutes + ":" + seconds.ToString();
        }
        
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Score += 1;
            

            minutes = Mathf.Floor(Score / 60);
            seconds = Mathf.RoundToInt(Score % 60);
        }
    }
}
