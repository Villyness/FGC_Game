using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.XR.WSA.Input;
using Random = System.Random;

public class Grunk : CharacterBase
{
    public event Action<int, CurrentAction> Lobbed;
    public event Action<int, CurrentAction> Curled;
    public event Action<int, CurrentAction> ChokeHold;

	// Use this for initialization
	void Start ()
	{
	    CurrentHealth = 100;
	    FindObjectOfType<Rabbit>().Attacked += OwnTurn;
        FindObjectOfType<Rabbit>().Grabbed += Change;
	}

    public override void Attack()
    {
        MyCurrentAction = CurrentAction.Attacking;
        AtkDamage = 10; // Remove when done
        if (Lobbed != null)
        {
            Lobbed(AtkDamage, MyCurrentAction);
        }
        //Debug.Log("Hello!");
        DefendValue = 0;
    }

    public override void Defend()
    {
        MyCurrentAction = CurrentAction.Defending;
        if (Curled != null)
        {
            Curled(DefendValue, MyCurrentAction);
        }
        DefendValue = 5;
    }

    public override void Grab()
    {
        MyCurrentAction = CurrentAction.Grabbing;
        GrabDamage = 20;
        if (ChokeHold != null)
        {
            ChokeHold(GrabDamage, MyCurrentAction);
        }

        DefendValue = -5;
    }

    public void OwnTurn(int dmg, CurrentAction playerAction)
    {
        Change(dmg, playerAction);
        switch (UnityEngine.Random.Range(0, 2))
        {
            case 0:
                Attack();
                break;
            case 1:
                Defend();
                break;
            case 2:
                Grab();
                break;
        }
    }
}
