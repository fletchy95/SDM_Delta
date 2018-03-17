using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogHolder : MonoBehaviour
{
    public string dialogue;
    private DialogueManager dialogueManager;    // Allows editing of DialogeManager Class.  
    public string[] dialogueLines;
	void Start ()
    // Sets dialogueManager to the object (class) DialogueManager. 
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
	}
	void Update ()
    {
        // Do Nothing.  
    }
    void OnTriggerStay2D(Collider2D col)
    /* Input: N/A (Runs in place of Update.  Will test once per frame).
     * Purpose: Will test for collision from gameObject Avatar (Point A).  Once true it ensures
     * that the DialogueManager is not currently active (Point  B).  If that says false (inactive
     * DialogueManager) then it will send over the dialogueLines to DialogueManager's 
     * dialogueLines for displaying to the user.  
     */
    {
        if(col.gameObject.name == "Avatar")
        {
            if(Input.GetKeyDown(KeyCode.Return))
            // Point A
            {
                if(!dialogueManager.dialogActive)
                // Point B
                {
                    dialogueManager.dialogLines = this.dialogueLines;
                    dialogueManager.currentLine = 0;
                    dialogueManager.ShowDialogue();
                }
            }
        }
    }
}
