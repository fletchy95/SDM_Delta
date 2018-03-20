using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int levelNumber; // Created in Unity.  Default = 1.  
    private AvatarController avatarController;
    void Start()
    {
        avatarController = FindObjectOfType<AvatarController>();
    }
    void Update()
    {
        QuitConstant();
    }
    public void LoadLevel(string name)
    /* Input: N/A
     * Purpose: Overloaded function for LoadLevel().  It is used to LoadLevel that have a 
     * string input.  
     */
    {
        if (name == "Quit")
        {
            Application.Quit();
        }
        else
        {
            Application.LoadLevel(name);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    // Run when Avatar or Object collides with Trigger event.  
    // Takes place of Update Method, testing once per frame.  
    {
        if (this.levelNumber != 0)
        {
            LoadLevel(this.levelNumber);
        }
        else
        {
            LoadLevel();
        }
    }
    public void LoadLevel(int levelNumber)
    /* Input: int levelNumber, to tell apart levels.  
     * Purpose: Allow the user to teleport from Level A to Level B smoothly.  
     */
    {
        Application.LoadLevel("Level" + levelNumber);
    }
    public void LoadLevel()
    /* Input: N/A
     * Purpose: Overloaded function for LoadLevel().  It is used to leave levels,
     * and go to the HomeTown.  The keyAccess part is to ensure the user completes the 
     * task prior to leaving the building.  
     */
    {
        if (avatarController.keyAccess == true)
        {
            Application.LoadLevel("HomeTown");
            avatarController.keyAccess = false;
        }
    }
    public void QuitConstant()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}