using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static float Score;
    private float BeginTime;

    Text ScoreText;
    Text TimeText;

    void Start()
    {
        BeginTime = Time.time;
    }
    void Awake()
    {
        ScoreText = GetComponent<Text>();
        
        Score = 0f;
    }


    void Update()
    {
       
        ScoreText.text = "Score: " + Score;
        TimeText.text = "Time:" + (Time.time - BeginTime);
    }
}