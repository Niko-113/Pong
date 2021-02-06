using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject paddleLeft;
    public GameObject paddleRight;

    private int speed = 5;

    // help???

    private float leftInput;
    private float rightInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftInput = Input.GetAxis("LeftInput");
        rightInput = Input.GetAxis("RightInput");
        paddleLeft.transform.Translate(new Vector3(0, leftInput, 0) * speed * Time.deltaTime);
        paddleRight.transform.Translate(new Vector3(0, rightInput, 0) * speed * Time.deltaTime);
        
    }
}
