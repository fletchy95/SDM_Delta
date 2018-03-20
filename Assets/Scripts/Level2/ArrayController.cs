using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayController : MonoBehaviour
{
    //public bool inArea = false;
    private ArrayManager arrayManager;
    private AvatarController avatarController;
    private SpriteRenderer spriteRenderer;
    void Start()
    // Runs once, gives objects they're appropreate object Type.  
    {
        avatarController = FindObjectOfType<AvatarController>();
        arrayManager = FindObjectOfType<ArrayManager>();
        spriteRenderer = FindObjectOfType<SpriteRenderer>();
    }
    void Update()
    {
        // Do Nothing.
    }
    private void OnTriggerStay2D(Collider2D collision)
    /* Input: N/A (Updates once per frame, while collide is active)
     * Purpose: It allows the user to move the boxes to the stack and attempt
     * to unlock the door.  Depending on the keycode in will run one of two 
     * methods that move boxes.  
     */
    {
        if ((Input.GetKey(KeyCode.P)) && !arrayManager.unlockBox)
        {
            MoveBox();
        }
    }
    private void MoveBox()
    /* Input: It allows for correct placement and future placement of boxes.
     * Purpose: To move boxes from one location to they other.  Will move boxes
     * to the 2x3 array.  Also unlocks the command to leave the house.  
     */
    {
        arrayManager.arrayMoved[5] = true;
        if (arrayManager.arrayMoved[0])
        { 
            arrayManager.unlockBox = true;
            transform.position = new Vector2(-2.96f, -1.64f);
            print(transform.position.x);
        }
        else if (arrayManager.arrayMoved[1])
        {
            transform.position = new Vector2(-5.57f, -5.25f);
            print(transform.position.x);
            arrayManager.arrayMoved[0] = true;
        }
        else if (arrayManager.arrayMoved[2])
        {
            transform.position = new Vector2(-8.1f, -5.25f);
            print(transform.position.x);
            arrayManager.arrayMoved[1] = true;
        }
        else if (arrayManager.arrayMoved[3])
        {
            transform.position = new Vector2(-2.95f, -5.25f);
            print(transform.position.x);
            arrayManager.arrayMoved[2] = true;
        }
        else if (arrayManager.arrayMoved[4])
        {
            transform.position = new Vector2(-8.1f, -1.64f);
            print(transform.position.x);
            arrayManager.arrayMoved[3] = true;
        }
        else if (arrayManager.arrayMoved[5])
        {
            transform.position = new Vector2(-5.6f, -1.64f);
            print(transform.position.x);
            arrayManager.arrayMoved[4] = true;
        }
        else
        {
            // Do Nothing.
        }
    }
}

