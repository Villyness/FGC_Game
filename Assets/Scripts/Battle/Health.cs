using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;

	// Use this for initialization
	void Start ()
	{
	    //FindObjectOfType<Rabbit>().Damage += Change;
	    //print(health);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

    void Change(int amount)
    {
        health -= amount;
    }
}
