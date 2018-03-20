using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteraction : MonoBehaviour {


    private DialogueManager dialogueManager;    // Allows editing of DialogeManager Class.  
    public string[] dialogueLinesLocked;
    public string[] dialogueLinesKey;
    public string[] dialogueLinesEmpty;
    public Light blueRock, redRock, yellowRock;
    private bool isLocked;
    public bool isEmpty;

    // Use this for initialization
    void Start()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
        isLocked = true;
        isEmpty = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (blueRock.color == Color.blue
           && redRock.color == Color.red
           && yellowRock.color == Color.yellow)
        {
            isLocked = false;
        }
        else isLocked = true;

    }

    void LockedText()
    {
        if (!dialogueManager.dialogActive)
            // Point B
            {
                dialogueManager.dialogLines = this.dialogueLinesLocked;
                dialogueManager.currentLine = 0;
                dialogueManager.ShowDialogue();
            }
    }

    void KeyText()
    {
        if (!dialogueManager.dialogActive)
            // Point B
            {
                dialogueManager.dialogLines = this.dialogueLinesKey;
                dialogueManager.currentLine = 0;
                dialogueManager.ShowDialogue();
            }
    }

    void EmptyText()
    {
        if (!dialogueManager.dialogActive)
        // Point B
        {
            dialogueManager.dialogLines = this.dialogueLinesEmpty;
            dialogueManager.currentLine = 0;
            dialogueManager.ShowDialogue();
        }
    }

    void OnTriggerStay2D(Collider2D col)
    /* Input: N/A (Runs in place of Update.  Will test once per frame).
     * Purpose: Will test for collision from gameObject Avatar (Point A).  Once true it ensures
     * that the DialogueManager is not currently active (Point  B).  If that says false (inactive
     * DialogueManager) then it will send over the dialogueLines to DialogueManager's 
     * dialogueLines for displaying to the user.  
     */
    {
        if (col.gameObject.name == "Avatar")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            // Point A
            {
                if (!isEmpty)
                {
                    if (isLocked)
                    {
                        LockedText();
                    }
                    else
                    {
                        KeyText();
                        isEmpty = true;
                    }
                }
                else EmptyText();
            }
        }
    }

}
