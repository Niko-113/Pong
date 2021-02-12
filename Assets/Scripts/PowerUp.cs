using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public void Restart(){
        // Set random coords
        this.transform.position = new Vector3(Random.Range(-4, 4), Random.Range(-1, 3), -3);
    }
    void OnTriggerEnter(Collider other){
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

        other.gameObject.GetComponent<Ball>().speed += 4;
        rb.velocity = new Vector3(rb.velocity.x * 2, rb.velocity.y * 2, 0);

        other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        other.gameObject.GetComponent<TrailRenderer>().material.SetColor("_Color", Color.red);

        // Disappear from the playing field
        this.transform.position = new Vector3(20, 20, 20);
    }
}
