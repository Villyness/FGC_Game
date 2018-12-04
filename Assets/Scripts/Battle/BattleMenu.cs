using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMenu : MonoBehaviour
{
    public bool PlayerTurn;

	// Use this for initialization
	void Start ()
	{
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
