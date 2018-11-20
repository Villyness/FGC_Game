using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterBase:MonoBehaviour
{
    public int CurrentHealth;
    public int AtkDamage;
    public int GrabDamage;

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

    public void Change(int amount)
    {
        CurrentHealth -= amount;
    }

}
