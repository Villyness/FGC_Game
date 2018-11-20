using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rabbit : CharacterBase
{
    public event Action<int> Attacked;

    public override void Attack()
    {
        AtkDamage = 10;
        if (Attacked != null)
        {
            Attacked(AtkDamage);
        }
        //Debug.Log("Hello!");
    }
	
}
