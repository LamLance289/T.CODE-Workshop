using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoController : MonoBehaviour
{

    public bool isGrounded;
    Rigidbody rb;
    bool isgrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionStay()
    {
        isgrounded = true;
    }
    void Update()
    {
        //Jump if pressing space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 5, 0),
           ForceMode.Impulse);
            isgrounded = false;

        }
    }
}
    


