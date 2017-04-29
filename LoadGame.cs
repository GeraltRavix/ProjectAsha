using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    public void LoadScene(string Name)
    {
        Application.LoadLevel(Name);
    }
	
}
