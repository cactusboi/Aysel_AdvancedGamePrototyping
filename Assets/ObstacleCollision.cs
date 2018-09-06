using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{

    public int ScoreValue = 250;
    void Start()
    {

    }
    
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Points")
        {

            Debug.Log("added 250 points");
            ScoreManager.Score += ScoreValue;
            Destroy(other);
        }

        if (other.gameObject.tag == "PointsRemove")
        {

            Debug.Log("removed 250 points");
            ScoreManager.Score -= ScoreValue;
            Destroy(other);
        }
    }
}