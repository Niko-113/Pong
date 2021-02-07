using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
         rigid = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (rigid.position.y > 4){
        //     rigid.velocity = new Vector3(0, 0, 0);
        //     rigid.position = new Vector3(rigid.position.x, 4, rigid.position.z);
        // }
    }

    void OnCollisionEnter(Collision collision){
        //Debug.Log($"{this.name} collided with the {collision.gameObject.name}");
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        Ball fun = collision.gameObject.GetComponent<Ball>();

        //Debug.Log(fun.speed);
        fun.speed += 0.1f;
    
       
       // TODO: Merge these all into one line instead? Calculate transform.up by subtracting positions or something
        // if (rb.position.y < this.GetComponent<Rigidbody>().position.y){
        //     Debug.Log("Ball is below");
        //     rb.AddForce((transform.right + (transform.up * -1)) * fun.speed, ForceMode.Impulse);
        // }
        // else if(rb.position.y > this.GetComponent<Rigidbody>().position.y){
        //      Debug.Log("Ball is above");
        //     rb.AddForce((transform.right + (transform.up)) * fun.speed, ForceMode.Impulse);
        // }
        // else{
        //     rb.AddForce((transform.right * fun.speed), ForceMode.Impulse);
        // }

        Vector3 angle = transform.right;
        angle.y = rb.position.y - rigid.position.y;
        rb.AddForce((angle) * fun.speed, ForceMode.Impulse); // Might be better to use something other than addforce to prevent weird slow bounces 
        
    }
}
