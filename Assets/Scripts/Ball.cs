using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 1;
    public Vector3 previousVelocity; // Should probably use a get function instead of making this public but w/e 
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-2, 1, 0);
        

    }


    void Restart()
    {

    }



    void FixedUpdate(){
        previousVelocity = rb.velocity;
    }
}
