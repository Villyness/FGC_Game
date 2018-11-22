using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuNav : MonoBehaviour
{
	[SerializeField] private Button startGame;
	[SerializeField] private Button credits;
	[SerializeField] private Button exitApp;

	// Use this for initialization
	void Start ()
	{
		Button sbtn = startGame.GetComponent<Button>();
		sbtn.onClick.AddListener(StartGame);

		Button cbtn = credits.GetComponent<Button>();
		cbtn.onClick.AddListener(Credits);

		Button ebtn = exitApp.GetComponent<Button>();
		ebtn.onClick.AddListener(ExitApp);
	}

	void StartGame ()
	{
		SceneManager.LoadScene(1);
	}

	void Credits ()
	{
		SceneManager.LoadScene(2);
	}

	void ExitApp ()
	{
		Application.Quit();
	}
}
