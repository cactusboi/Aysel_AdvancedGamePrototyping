using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {

        if (gameObject.tag == "PlayerBack")
        {
            var x = Input.GetAxis("HorizontalBack") * Time.deltaTime * 150.0f;
            var y = Input.GetAxis("JumpBack") * Time.deltaTime * 10.0f;
            var z = Input.GetAxis("VerticalBack") * Time.deltaTime * 3.0f;

            transform.Rotate(0, x, 0);
            transform.Translate(0, y, 0);
            transform.Translate(0, 0, z);
        }

        if (gameObject.tag == "PlayerFront")
        {
            var x = Input.GetAxis("HorizontalFront") * Time.deltaTime * 150.0f;
            var y = Input.GetAxis("JumpFront") * Time.deltaTime * 10.0f;
            var z = Input.GetAxis("VerticalFront") * Time.deltaTime * 3.0f;

            transform.Rotate(0, x, 0);
            transform.Translate(0, y, 0);
            transform.Translate(0, 0, z);
        }
    }
}
