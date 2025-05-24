using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // fields
    private Rigidbody rb;


    // methods

    // is called before the first frame update
    void Start()    // called once
    {
        Debug.Log("Starting ");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()   // called every frame
    {
        Debug.Log("Updating ");

            // Input: preexisting class,
            // GetKey: a method/function inside Input
        if (Input.GetKey("up"))
        {
            rb.velocity = new Vector3(0, 0, -1);
        }

    }
}
