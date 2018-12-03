using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterBase:MonoBehaviour
{
    public enum CurrentAction
    {
        Attacking,
        Defending,
        Grabbing
    };

    public CurrentAction MyCurrentAction;

    public int CurrentHealth;
    public int AtkDamage;
    public int GrabDamage;
    public int DefendValue;
    //private int actualHealth;

    public virtual void Attack()
    {
        //Debug.Log("Yo!");
    }

    public virtual void Defend()
    {

    }

    public virtual void Grab()
    {

    }

    public virtual void Skill1()
    {

    }

    public virtual void Skill2()
    {

    }

    public virtual void Change(int amount, CurrentAction EnemyState)
    {
        if (MyCurrentAction == CurrentAction.Defending && EnemyState == CurrentAction.Grabbing)
        {
            CurrentHealth -= amount;
        }
        else
        {
            CurrentHealth -= (amount - DefendValue);
        }

        DefendValue = 0;
    }

}
