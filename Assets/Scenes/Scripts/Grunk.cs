using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grunk : CharacterBase
{

	// Use this for initialization
	void Start ()
	{
        
	    FindObjectOfType<Rabbit>().Attacked += Change;
	}
}
