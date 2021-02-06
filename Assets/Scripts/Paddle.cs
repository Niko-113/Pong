using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private Vector3 angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        Debug.Log($"{this.name} collided with the {collision.gameObject.name}");
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        Ball fun = collision.gameObject.GetComponent<Ball>();

        //angle = collision.relativeVelocity;
        Debug.Log(fun.speed);
        fun.speed += 0.1f;
    
        rb.AddForce((transform.right * fun.speed), ForceMode.Impulse);
        
    }
}
