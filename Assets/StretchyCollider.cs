using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StretchyCollider : MonoBehaviour {

    public Transform FrontBone;
    public Transform BackBone;
    public BoxCollider ColliderToStretch;
    public Rigidbody DogMid;
    public float StretchRatio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ColliderToStretch.size = new Vector3(ColliderToStretch.size.x, ColliderToStretch.size.y, Vector3.Distance(FrontBone.position, BackBone.position) * StretchRatio);
        DogMid.position = ((FrontBone.transform.position + BackBone.transform.position) / 2);

    }
}
