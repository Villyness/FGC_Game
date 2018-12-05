using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject _battleMenu;
    private GameObject _playerMenu;

	// Use this for initialization
	void Start ()
	{
		_battleMenu = GameObject.Find("BattleManager");
        _playerMenu = GameObject.Find("BattleMenu1");

	    FindObjectOfType<BattleMenu>().GameSet += SceneSwitch;
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

    public void SceneSwitch(int sceneNumber)
    {
        SceneManager.LoadScene(3);
    }
}
