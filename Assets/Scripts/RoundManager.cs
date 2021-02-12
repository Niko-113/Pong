using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour
{

    private int leftScore = 0;
    private int rightScore = 0;

    public Ball ball;
    public PowerUp power;
    public Bumper bumper;
    public Text leftText;
    public Text rightText;

    void Restart()
    {
        leftScore = 0;
        rightScore = 0;
    }

    

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

        power.Restart();
        bumper.Restart();
        leftText.text = "" + leftScore; // Should probably check if C# has its own string conversion thing
        rightText.text = "" + rightScore;
        

        // More elegant way to do this probably but I don't feel like doing the math
        if(leftScore > rightScore){
            leftText.color = Color.green;
            rightText.color = Color.red;
        } else if (rightScore > leftScore){
            leftText.color = Color.red;
            rightText.color = Color.green;
        } else{
            leftText.color = Color.white;
            rightText.color = Color.white;
        }
        

    }
}
