using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityController : MonoBehaviour
{

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb)
        {
            rb.velocity = Vector3.right;
            
        }
    }
}
	
	
	
