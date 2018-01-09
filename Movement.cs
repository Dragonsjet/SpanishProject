using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour {
    public Vector2 jump;
    public float jumpForce = 2.0f;
    Rigidbody2D rb;
    public bool isGrounded;
    Vector3 position;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    //void OnCollision()


    

    // Update is called once per frame
    void Update () {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position = this.transform.position;
            position.x -= 0.2f;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position = this.transform.position;
            position.x += 0.2f;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        {
            rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            //isGrounded = false;
        }
    }
}
