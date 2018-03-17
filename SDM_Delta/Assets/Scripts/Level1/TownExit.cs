using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TownExit : MonoBehaviour {
    public ChestInteraction chest;
    private DialogueManager dialogueManager;
    public string[] dialogueLinesStuck;
    
    // Use this for initialization
    void Start ()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Avatar")
        {
            if (chest.isEmpty)
            {
                SceneManager.LoadScene("HomeTown");
            }
            else
            {
                dialogueManager.dialogLines = this.dialogueLinesStuck;
                dialogueManager.currentLine = 0;
                dialogueManager.ShowDialogue();
            }
        }
    }
}
