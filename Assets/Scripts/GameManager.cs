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
	    if (SceneManager.GetActiveScene().buildIndex == 1)
	    {
                _battleMenu = GameObject.Find("BattleManager");
                _playerMenu = GameObject.Find("BattleMenu1");

                FindObjectOfType<BattleMenu>().GameSet += SceneSwitch;
        }

	    if (SceneManager.GetActiveScene().buildIndex == 3)
	    {
	        FindObjectOfType<SelectDialogue>().Confirm += SceneSwitch;
        }
	}
	
	// Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
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

    public void SceneSwitch(int sceneNumber)
    {
        if (sceneNumber == 0)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(3);
        }
        
    }
}
