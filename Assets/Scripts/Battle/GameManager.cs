using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject _battleMenu;
    private GameObject _playerMenu;

	// Use this for initialization
	void Start ()
	{
		_battleMenu = GameObject.Find("BattleManager");
        _playerMenu = GameObject.Find("BattleMenu1");
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (_battleMenu.GetComponent<BattleMenu>().PlayerTurn == false)
	    {
            _playerMenu.SetActive(false);
	    }
	    else
	    {
            _playerMenu.SetActive(true);
	    }
	}
}
