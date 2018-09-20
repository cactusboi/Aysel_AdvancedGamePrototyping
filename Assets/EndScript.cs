using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScript : MonoBehaviour
{

    private float TierCalc;
    public Text TierText;
    public GameObject EndCanvas;

    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        TierCalc = (ScoreManager.Score - ScoreManager.TotalTime);
        Debug.Log("end");
        EndCanvas.SetActive(true);
        if (TierCalc >= 1000)
        {
            TierText.text = "You got a gold medal!";
        }

        if (TierCalc >= 500 && TierCalc < 1000)
        {
            TierText.text = "You got a silver medal.";
        }
        else
        {
            TierText.text = "You got a bronze medal.";
        }
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}