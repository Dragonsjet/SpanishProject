using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public Rigidbody rb;
    void Start()
    {
    rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, 10, 0);

        }
    }
 
}
