using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other){
        Rigidbody ball = other.gameObject.GetComponent<Rigidbody>();
        ball.velocity = new Vector3(ball.velocity.x, ball.velocity.y * -1, 0);


    }
}
