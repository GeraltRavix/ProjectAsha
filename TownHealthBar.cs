using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownHealthBar : MonoBehaviour
{
    public double TownHealth = 100;
    public double FoodLevel = 100;
    public double MedicineLevel = 100;
    public double DamageLevel = 0.01;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(FoodLevel <= 80 || MedicineLevel <= 80)
        {
            TownHealth = TownHealth - (DamageLevel*2);
        }
        else if(FoodLevel <= 80)
        {
            TownHealth = TownHealth - DamageLevel;
        }
        else if(MedicineLevel <= 80)
        {
            TownHealth = TownHealth - DamageLevel;
        }
        print(TownHealth);
	}
}
