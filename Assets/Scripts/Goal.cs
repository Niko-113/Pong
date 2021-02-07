using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public RoundManager master;
    

    void OnTriggerEnter(Collider collision)
    {
        master.score(this.transform.position.x);
    }



}
