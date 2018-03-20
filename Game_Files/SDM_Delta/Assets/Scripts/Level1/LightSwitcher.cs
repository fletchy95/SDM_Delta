using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LightSwitcher : MonoBehaviour {
    public new Light light;
    

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
        light.color = Color.clear;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    /* Input: N/A (Runs in place of Update.  Will test once per frame).
     * Purpose: Will test for collision from gameObject Avatar (Point A).  Once true it ensures
     * that the DialogueManager is not currently active (Point  B).  If that says false (inactive
     * DialogueManager) then it will send over the dialogueLines to DialogueManager's 
     * dialogueLines for displaying to the user.  
     */
    {
        if (col.gameObject.name == "Avatar")
        {
            LightChanger();
        }

    }

    void LightChanger()
    {
        //if (Input.GetKeyDown(KeyCode.Return))
        // Point A
        {
            if (light.color == Color.clear)
            {
                light.color = Color.yellow;
            }
            if (light.color == Color.yellow)
            {
                light.color = Color.blue;
            }
            else if (light.color == Color.blue)
            {
                light.color = Color.red;
            }
            else if (light.color == Color.red)
            {
                light.color = Color.yellow;
            }
        }
    }
    
}
