using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    
    public void Restart(){
        // Set random coords
        this.transform.position = new Vector3(Random.Range(-4, 4), Random.Range(-1, 3), -3);
    }

    void OnTriggerEnter(Collider other){
        Rigidbody ball = other.gameObject.GetComponent<Rigidbody>();
        ball.velocity = new Vector3(ball.velocity.x, ball.velocity.y * -1, 0);

        // Disappear from the playing field
        this.transform.position = new Vector3(25, 25, 25);
    }
}
