using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOver : MonoBehaviour {

    public int ScoreValue = 125;
    void Start () {
		
	}
	
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Floor")
        {

            Debug.Log("removed 250 points");
            ScoreManager.Score -= ScoreValue;
        }
    }
}
