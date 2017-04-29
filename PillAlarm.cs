//Reference to some code: http://answers.unity3d.com/questions/532086/how-to-make-text-pop-up-for-a-few-seconds.html
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillAlarm : MonoBehaviour
{
    private bool showText = false, someRandomCondition = true;
    private float currentTime = 0.0f, executedTime = 0.0f, timeToWait = 5.0f;

    // Use this for initialization
    void Start ()
    {
		
	}

    void OnMouseDown()
    {
        executedTime = Time.time;
    }

    // Update is called once per frame
    void Update ()
    {
        int TheTime = System.DateTime.Now.Hour;
        int TheTime2 = System.DateTime.Now.Minute;
        
        //print(TheTime);
        //print(TheTime2);
        //Can maybe implement an in game text pop up for now
        
        //
        if (TheTime == 8 & TheTime2 == 0)
        {
            //print("Take Your Medicine");
            if (someRandomCondition)
                showText = true;
            else
                showText = false;

            if (executedTime != 0.0f)
            {
                if (currentTime - executedTime > timeToWait)
                {
                    executedTime = 0.0f;
                    someRandomCondition = false;
                }
            }
        }
        else if (TheTime == 12 & TheTime2 == 0)
        {
            //print("Take Your Medicine");
            if (someRandomCondition)
                showText = true;
            else
                showText = false;

            if (executedTime != 0.0f)
            {
                if (currentTime - executedTime > timeToWait)
                {
                    executedTime = 0.0f;
                    someRandomCondition = false;
                }
            }
        }
        else if(TheTime == 16 & TheTime2 == 0)
        {
            //print("Take Your Medicine");
            if (someRandomCondition)
                showText = true;
            else
                showText = false;

            if (executedTime != 0.0f)
            {
                if (currentTime - executedTime > timeToWait)
                {
                    executedTime = 0.0f;
                    someRandomCondition = false;
                }
            }
        }
    }

    void OnGUI()
    {
        if (showText)
            GUI.Label(new Rect(0, 0, 100, 100), "Take Your Medicine");
    }
}
