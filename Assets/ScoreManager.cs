using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static float Score;
    private float BeginTime;
    private float TotalTime;

    public Text ScoreText;
    public Text TimeText;

    void Start()
    {
        BeginTime = Time.time;
    }
    void Awake()
    {
        //ScoreText = GetComponent<Text>();
        //TimeText = GetComponent<Text>();
        
        Score = 0f;
    }


    void Update()
    {
       
        ScoreText.text = "Score: " + Score;
        TotalTime = Time.time - BeginTime;
        TimeText.text = "Time:" + TotalTime.ToString("F0") + " seconds";
    }
}