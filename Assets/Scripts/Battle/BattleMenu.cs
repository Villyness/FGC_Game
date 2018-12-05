using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BattleMenu : MonoBehaviour
{
    public bool PlayerTurn;
    public event Action<int> GameSet;

    private int _sceneNumber;

	// Use this for initialization
	void Start ()
	{
	    _sceneNumber = 3;

	    FindObjectOfType<Rabbit>().Attacked += TurnSwitch;
	    FindObjectOfType<Rabbit>().Defended += TurnSwitch;
	    FindObjectOfType<Rabbit>().Grabbed += TurnSwitch;

	    FindObjectOfType<Grunk>().Lobbed += TurnSwitch;
	    FindObjectOfType<Grunk>().Curled += TurnSwitch;
	    FindObjectOfType<Grunk>().ChokeHold += TurnSwitch;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (FindObjectOfType<Rabbit>().CurrentHealth <= 0)
	    {
	        if (GameSet != null)
	        {
	            GameSet(_sceneNumber);
	        }
	    }
	}

    public void TurnSwitch(int damage, CharacterBase.CurrentAction action)
    {
        if (PlayerTurn == true)
        {
            PlayerTurn = false;
            //Debug.Log("Enemy's turn!");
        }
        else
        {
            PlayerTurn = true;
        }
    }
}
