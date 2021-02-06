using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 1;
    Rigidbody rb;
    private Vector3 impactValue;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-2, 1, 0);
        

    }


    void Restart()
    {

    }

    void OnCollisionEnter(Collision collision){
        // impactValue = collision.relativeVelocity;
        // speed += 0.1f;
        // rb.AddForce((impactValue * speed), ForceMode.Impulse);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
