using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour {

    public GameObject Coin;
    private Vector3 BuildingLocation;
    private bool IsBuilding;
    private float TargetTime = 5;
	// Use this for initialization
	void Start ()
    {
        BuildingLocation = GameObject.FindGameObjectWithTag("Building").transform.position;
        IsBuilding = GameObject.FindGameObjectWithTag("Building");
        //Instantiate(Coin, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(Coin, BuildingLocation, Quaternion.identity);
    }


    // Update is called once per frame
    void Update ()
    {
        BuildingLocation = GameObject.FindGameObjectWithTag("Building").transform.position;
        IsBuilding = GameObject.FindGameObjectWithTag("Building");
        //print(IsBuilding);
        if (IsBuilding == true)
        {
            Instantiate(Coin, BuildingLocation, Quaternion.identity);
            IsBuilding = false;
        }
        //print(IsBuilding);

        //Timer = Time.time + 5;
        //print(Timer);
        //print(TargetTime);
        //print(Time.time);
        if(TargetTime >= Time.time)
        {
            Instantiate(Coin, BuildingLocation, Quaternion.identity);
            TargetTime = Time.time + 5;
            
            //print("test");
        }


        
		
	}

}
