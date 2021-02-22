using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Control : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    private void OnTriggerExit(Collider other)
    {
        if(other.tag=="Player")
        {
            rb.AddForce(new Vector3(0, 0, 200f));

        }
    }
}
