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
            transform.Translate(0, jump, 0);

            if (movement != Vector3.zero)
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.1F);

            rb.AddForce(movement * speed);
        }

        if (gameObject.tag == "PlayerBack")
        {
            float moveHorizontal = Input.GetAxis("HorizontalBack");
            float moveVertical = Input.GetAxis("VerticalBack");
            float jump = Input.GetAxis("JumpBack") * Time.deltaTime * 5.0f;

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            transform.Translate(0, jump, 0);

            rb.AddForce(movement * speed);
        }

        if ((Input.GetKeyDown(KeyCode.Space)) || (Input.GetKeyDown(KeyCode.R)))
        {
            SceneManager.LoadScene(0);
        }
    }
}


