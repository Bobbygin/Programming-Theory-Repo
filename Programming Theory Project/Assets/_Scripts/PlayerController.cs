using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public float speed = 10.0f;
    public float horizontalInput;
    public float xRange = 52;
    public float yForce= 30f;
    Rigidbody rb;
    public float time = 1.5f;
    public float timer = 0f;
    void Start()
    {
        rb=GetComponent<Rigidbody>();

    }
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        timer += Time.deltaTime;
        if (timer >= time)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(0, yForce, 0, ForceMode.Impulse);
                timer = 0;
            }
        }
    }

}
