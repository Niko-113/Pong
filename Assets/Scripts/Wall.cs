using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        Ball fun = collision.gameObject.GetComponent<Ball>();

        Vector3 flip = new Vector3(fun.previousVelocity.x, fun.previousVelocity.y * -1, 0);

        //rb.AddForce(flip, ForceMode.Impulse);
        rb.velocity = flip;
    }
}
