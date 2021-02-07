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
        rb.velocity = new Vector3(-4, 2, 0);
        

    }


    public void Restart(int direction)
    {
        speed = 4;
        rb.position = new Vector3(0, 1.29f, -3);
        rb.velocity = new Vector3(4 * direction, 2, 0);
    }



    void FixedUpdate(){
        previousVelocity = rb.velocity;
    }
}
