using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public Text dialogueText;
    public bool dialogActive;
    public string[] dialogLines;
    public int currentLine;
    private AvatarController avatarController;  // Used to edit canMove (boolean value).  

	void Start ()
    // Sets avatarController to the object (class) AvatarController.  
    {
        avatarController = FindObjectOfType<AvatarController>();
    }
	void Update ()
    // Runs once per frame.  
    {
        DialogueController();
    }
    private void DialogueController()
    /* Input: N/A Ran from update function.
     * Purpose: This allows the user to tab through the text dialogue that a
     * NPC will try to communicate to the user (Point A).  It also will alow the Avatar to
     * move (Point B).  It will also reset the dialogue lines and hide the box (Point C).
     */
    {
        if (dialogActive && Input.GetKeyDown(KeyCode.Space))
        // Point A.
        {
            currentLine++;
        }
        if (currentLine >= dialogLines.Length)
        // Point C.  
        {
            dialogueBox.SetActive(false);
            dialogActive = false;
            currentLine = 0;
            avatarController.canMove = true;    // Point B.  
        }
        dialogueText.text = dialogLines[currentLine];
    }
    public void ShowDialogue()
    /* Input: N/A (Ran from DialogHolder Class).
     * Purpose: It will stop the avatar from moving, force the Stationary method to run
     * then open the dialog box, and display the dialog text.  
     */
    {
        avatarController.canMove = false;
        avatarController.Stationary(avatarController.savedDirection);
        dialogueBox.SetActive(true);
        dialogActive = true;
    }
}
