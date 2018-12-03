using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rabbit : CharacterBase
{
    public int Defense;

    public event Action<int, CurrentAction> Attacked;

    void Start()
    {
        CurrentHealth = 100;
        FindObjectOfType<Grunk>().Lobbed += Change;
        FindObjectOfType<Grunk>().ChokeHold += Change;
    }

    public override void Attack()
    {
        MyCurrentAction = CurrentAction.Attacking;
        AtkDamage = 10; // Remove when done
        if (Attacked != null)
        {
            Attacked(AtkDamage, MyCurrentAction);
        }
        //Debug.Log("Hello!");
        DefendValue = 0;
    }

    public override void Defend()
    {
        DefendValue = 5;
        MyCurrentAction = CurrentAction.Defending;
    }
	
}
