using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StretchyCollider : MonoBehaviour {

    public Transform FrontBone;
    public Transform BackBone;
    public BoxCollider ColliderToStretch;
    public Rigidbody MidBone;
    public Rigidbody MidCollider;
    public Transform MidBoneTrans;
    public float StretchRatio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ColliderToStretch.size = new Vector3(ColliderToStretch.size.x, ColliderToStretch.size.y, Vector3.Distance(FrontBone.position, BackBone.position) * StretchRatio);
        MidBoneTrans.position = ((FrontBone.transform.position + BackBone.transform.position) / 2);
        MidCollider.position = MidBone.position;
        //navmesh dude to the position of midbone.position in the update


    }

    /*private void FixedUpdate()
    {
        MidBone.MovePosition(((FrontBone.transform.position + BackBone.transform.position) / 2) * (20 * Time.deltaTime));
    }*/
}

    