using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Archie : MonoBehaviour
{
    public Text DialogueBox;
    public Canvas Board;

    public GameObject DialogueChoice;

    private bool _asked = false;

    // Use this for initialization
	void Start ()
	{
	    FindObjectOfType<Interact>().Interacted += Dialogue;
	    //DialogueBox.text = "Test";
	}
	
	// Update is called once per frame
	void Update ()
	{
	    /*gameObject.AddComponent<Canvas>();
	    Board = GetComponent<Canvas>();*/
        
	}

    public void Dialogue()
    {
        switch (_asked)
        {
            case false:
                DialogueBox.text = "Oh hey there! Want some games?";
                break;
            case true:
                DialogueBox.text = "";
                DialogueChoice.SetActive(true);
                break;
        }
        _asked = true;
    }
}
