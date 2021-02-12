using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject paddleLeft;
    public GameObject paddleRight;

    private int speed = 5;


    private float leftInput;
    private float rightInput;


    
    void FixedUpdate()
    {
        leftInput = Input.GetAxis("LeftInput");
        rightInput = Input.GetAxis("RightInput");

        CheckLimits(paddleLeft, leftInput);
        CheckLimits(paddleRight, rightInput);
        
        // paddleLeft.transform.Translate(new Vector3(0, leftInput, 0) * speed * Time.deltaTime);
        // paddleRight.transform.Translate(new Vector3(0, rightInput, 0) * speed * Time.deltaTime);
        
       
        
    }

    void CheckLimits(GameObject paddle, float axis)
    {
        
        Rigidbody rb = paddle.GetComponent<Rigidbody>();
        if (rb.position.y > 4){
            rb.position = new Vector3(rb.position.x, 4, rb.position.z);
            //paddle.transform.position = new Vector3(paddle.transform.position.x, 4, paddle.transform.position.z);
            //rb.velocity = new Vector3(0, 0, 0);

            return;
        }
        else if(rb.position.y < -1.42){
            rb.position = new Vector3(rb.position.x, -1.42f, rb.position.z);
            return;
        }
        else{
            paddle.transform.Translate(new Vector3(0, axis, 0) * speed * Time.deltaTime);
            
        }
    }
}
