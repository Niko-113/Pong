using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private Rigidbody rigid;

    public AudioClip hitsound;
    public AudioSource speaker;

    // Start is called before the first frame update
    void Start()
    {
         rigid = this.GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision collision){
        //Debug.Log($"{this.name} collided with the {collision.gameObject.name}");
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        Ball fun = collision.gameObject.GetComponent<Ball>();

        //Debug.Log(fun.speed);
        fun.speed += 0.1f;

        speaker.pitch = 1 - (rb.velocity.magnitude / 30);
        speaker.PlayOneShot(hitsound);
    
       
       

        rb.velocity = new Vector3(fun.previousVelocity.x * 0, rb.velocity.y, 0);

        Vector3 angle = transform.right;
        angle.y = rb.position.y - rigid.position.y;
        rb.AddForce((angle) * fun.speed, ForceMode.Impulse); // Might be better to use something other than addforce to prevent weird slow bounces 
        
    }
}
