using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        if (gameObject.tag == "PlayerFront")
        {
            float moveHorizontal = Input.GetAxis("HorizontalFront");
            float moveVertical = Input.GetAxis("VerticalFront");
            float jump = Input.GetAxis("JumpFront") * Time.deltaTime * 5.0f;

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            transform.Translate(jump, 0, 0);

            
            rb.AddForce(movement * speed);
        }

        if (gameObject.tag == "PlayerBack")
        {
            float moveHorizontal = Input.GetAxis("HorizontalBack");
            float moveVertical = Input.GetAxis("VerticalBack");
            float jump = Input.GetAxis("JumpBack") * Time.deltaTime * 5.0f;

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            transform.Translate(jump, 0, 0);

            rb.AddForce(movement * speed);
        }
        if (Input.GetKey("space"))
        {
            SceneManager.LoadScene(0);
        }
    }
}


/* 
 void Update()
 {

     if (gameObject.tag == "PlayerBack")
     {
         var x = Input.GetAxis("HorizontalBack") * Time.deltaTime * 10.0f;
         var y = Input.GetAxis("JumpBack") * Time.deltaTime * 10.0f;
         var z = Input.GetAxis("VerticalBack") * Time.deltaTime * 10.0f;

         transform.Translate(x, 0, 0);
         transform.Translate(0, y, 0);
         transform.Translate(0, 0, z);
     }

     if (gameObject.tag == "PlayerFront")
     {
         var x = Input.GetAxis("HorizontalFront") * Time.deltaTime * 10.0f;
         var y = Input.GetAxis("JumpFront") * Time.deltaTime * 10.0f;
         var z = Input.GetAxis("VerticalFront") * Time.deltaTime * 10.0f;

         transform.Translate(x, 0, 0);
         transform.Translate(0, y, 0);
         transform.Translate(0, 0, z);
     }
 }
}*/
