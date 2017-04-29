///Based on code from tutorial: https://gamedevelopment.tutsplus.com/tutorials/how-to-save-and-load-your-players-progress-in-unity--cms-20934
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClass : MonoBehaviour {

    [System.Serializable]
    public class Game
    {

        public static Game current;
        public GameObject ThePatient;

        public Game()
        {
            ThePatient = new GameObject();
            //Extendable from here based on what else needs saving
            
        }

    }
}
