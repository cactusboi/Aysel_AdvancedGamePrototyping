using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


    public GameObject PlayerFront;
    public GameObject PlayerBack;

    private Vector3 offset;

    
    void Start()
    {
        offset = transform.position - PlayerFront.transform.position;
    }


    void LateUpdate()
    {
        transform.position = ((PlayerFront.transform.position + PlayerBack.transform.position)/2) + offset;
    }
}