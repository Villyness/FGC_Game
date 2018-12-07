using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Interact : MonoBehaviour
{
    public bool InRange;
    public event Action Interacted;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

    public void OnTriggerStay2D(Collider2D other)
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if (Interacted != null)
            {
                //Debug.Log("Hello!");
                Interacted();
            }
        }
        
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        InRange = false;
    }
}
