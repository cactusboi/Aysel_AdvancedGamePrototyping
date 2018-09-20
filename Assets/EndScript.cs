using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour {

    private float TierCalc;
	void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        TierCalc = (ScoreManager.Score - ScoreManager.TotalTime);
        if ((other.gameObject.tag == "PlayerFront") || (other.gameObject.tag == "PlayerFront"))
        {
            if (TierCalc >= 1000)
            {
                Debug.Log("gold");
                //ScoreManager.Score += ScoreValue;
                //Destroy(other);
            }

            if (TierCalc >= 500 && TierCalc < 1000)
            {
                Debug.Log("silver");
                //ScoreManager.Score += ScoreValue;
                //Destroy(other);
            }
            else
            {
                Debug.Log("Bronze");
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
