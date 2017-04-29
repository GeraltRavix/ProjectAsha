using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool isPaused = false;
    private bool ButtonPressed;

   public void PausesGame()
    //void Update()
    {
        //print("test");
        //ButtonPressed = Input.GetMouseButtonDown(0);
        ButtonPressed = Input.GetButtonDown("escape");
        //print(ButtonPressed);
        if( isPaused == false & ButtonPressed == true)
        {
            Time.timeScale = 0;
            isPaused = true;
            //print(isPaused);
        }
        else if (isPaused == true & ButtonPressed == true)
        {
            Time.timeScale = 1;
            isPaused = false;
            //print(isPaused);
        }
    }
}
