using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{

    private int leftScore = 0;
    private int rightScore = 0;
    public Ball ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Restart()
    {
        leftScore = 0;
        rightScore = 0;
    }

    // Update is called once per frame
    

    public void score(float side){
        string str = "";
        if (side > 0){
            str += "Left ";
            leftScore++;
            ball.Restart(1);
        }
        else{
            str += "Right ";
            rightScore++;
            ball.Restart(-1);
        }
        Debug.Log(str + "Paddle has scored!");
        Debug.Log("Current score is: " + leftScore + "-" + rightScore);

        if (leftScore == 11){
            Debug.Log("Left Paddle Wins!");
            Restart();
        }
        else if (rightScore == 11){
            Debug.Log("Right Paddle Wins!");
            Restart();
        }



    }
}
