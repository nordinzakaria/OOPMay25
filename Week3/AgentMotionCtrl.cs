using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Assets;
using System;
using Random = UnityEngine.Random;



public class AgentMotionCtrl : MonoBehaviour
{
    GameObject m_Agent;
    Rigidbody rb;
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;


    [SerializeField] AudioSource jumpSound;

    [SerializeField] Material[] colors = new Material[3];
    [SerializeField] TMP_Text dialog;

    bool isWobbling;
    Wobble wobble;
    GameObject arm;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_Agent = gameObject;
        Transform tr = transform.Find("Arm0");
        arm = tr.gameObject;
    }

    void MakeWobble(Vector3 direction, float frequency, float forceMagnitude)
    {
        isWobbling = true;
        wobble = new Wobble(direction, frequency, forceMagnitude);
    }

    void SayHello()
    {
        dialog.text = "Hello";
    }

    void MoveBack()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.velocity = new Vector3(0, 0, -movementSpeed);
    }

    void MoveBack2()
    {
        rb.constraints = RigidbodyConstraints.None;
        rb.velocity = new Vector3(0, 0, -movementSpeed);
    }


    void MoveFront2()
    {
        rb.constraints = RigidbodyConstraints.None;
        rb.velocity = new Vector3(0, 0, movementSpeed);
    }

    void MoveFront()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.velocity = new Vector3(0, 0, movementSpeed);
    }

    void TurnRed()
    {
        m_Agent.GetComponent<Renderer>().material = colors[1];
    }

    void TurnBlue()
    {
        m_Agent.GetComponent<Renderer>().material = colors[2];
    }

    void TurnGray()
    {
        m_Agent.GetComponent<Renderer>().material = colors[0];
    }

    void MoveArm()
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
        Console.WriteLine("moving arm " + arm);
        arm.GetComponent<Rigidbody>().velocity = new Vector3(movementSpeed, 0, 0);
    }


    // Update is called once per frame
    void Update()
    {
        if (isWobbling)
        {
            rb.AddForce(wobble.Direction * Mathf.Sin(Time.time * wobble.Frequency) * wobble.ForceMagnitude);
        }

        /*
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
        */

        if (Input.GetKey("1")) 
        {
            TurnRed();
        }
        else if (Input.GetKey("2"))
        {
            TurnBlue();
        }
        else if (Input.GetKey("3"))
        {
            TurnGray();
        }

        else if (Input.GetKey("4"))
        {
            SayHello();
        }
        else if (Input.GetKey("5"))
        {
            MakeWobble(new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f)),
                Random.Range(0, 10), Random.Range(0, 10));
            isWobbling = true;
        }
        else if (Input.GetKey("6"))
        {
            MoveArm();
        }

        if (Input.GetKey("up") && Input.GetKey(KeyCode.LeftControl))
        {
            MoveFront2();
        }
        else if (Input.GetKey("up"))
        {
            MoveFront();
        }
        else if (Input.GetKey("down") && Input.GetKey(KeyCode.LeftControl))
        {
            MoveBack2();
        }

        else if (Input.GetKey("down"))
        {
            MoveBack();
        }

        if (Input.GetButtonDown("Jump"))// && IsGrounded())
        {
            Jump();
        }
        
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        //jumpSound.Play();
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Head"))
        {
            Destroy(collision.transform.parent.gameObject);
            Jump();
        }
    }
    */

}
