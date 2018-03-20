using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryDialogue1 : MonoBehaviour {
    public string dialogue;
    private DialogueManager dialogueManager;
    public string[] dialogueLines;

    // Use this for initialization
    void Start () {
        dialogueManager = FindObjectOfType<DialogueManager>();
        if(!dialogueManager.dialogActive)
                // Point B
                {
                    dialogueManager.dialogLines = this.dialogueLines;
                    dialogueManager.currentLine = 0;
                    dialogueManager.ShowDialogue();
                }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
