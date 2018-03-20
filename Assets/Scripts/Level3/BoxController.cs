using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    public int boxNumber;
    private BoxManager boxManager;
    private AvatarController avatarController;
    private SpriteRenderer spriteRenderer;
	void Start ()
    // Runs once, gives objects they're appropreate object Type.  
    {
        avatarController = FindObjectOfType<AvatarController>();
        boxManager = FindObjectOfType<BoxManager>();
        spriteRenderer = FindObjectOfType<SpriteRenderer>();
    }
	void Update ()
    {
		// Do Nothing.  
	}
    private void OnTriggerStay2D(Collider2D collision)
    /* Input: N/A (Updates once per frame, while collide is active)
     * Purpose: It allows the user to move the boxes to and from the stack.
     * Depending on the keycode in will run one of two methods that move boxes.  
     */
    {
        if(Input.GetKey(KeyCode.P))
        {
            MoveBox(this.boxNumber);
        }
        else if(Input.GetKey(KeyCode.O))
        {
            ReturnBox(this.boxNumber);
        }
    }
    private void MoveBox(int boxNumber)
    /* Input: int boxNumber.  It allows for correct placement and future placement of boxes.
     * Purpose: To move boxes from one location to they other depending on if its going to 
     * the stack or leaving the stack as it does in ReturnBox.  
     */
    {
        boxManager.boxMoved[5] = true;
        if (boxManager.boxMoved[0])
        {
            transform.position = new Vector2(4.79f, 2.05f);
            print(transform.position.x);
            boxManager.boxMoved[0] = false;
            spriteRenderer.sortingOrder = boxManager.layerOrder[0];
        }
        else if(boxManager.boxMoved[1])
        {
            transform.position = new Vector2(4.79f, 0.39f);
            print(transform.position.x);
            boxManager.boxMoved[0] = true;
            spriteRenderer.sortingOrder = boxManager.layerOrder[1];
        }
        else if (boxManager.boxMoved[2])
        {
            transform.position = new Vector2(4.79f, -1.24f);
            print(transform.position.x);
            boxManager.boxMoved[1] = true;
            spriteRenderer.sortingOrder = boxManager.layerOrder[2];
        }
        else if (boxManager.boxMoved[3])
        {
            transform.position = new Vector2(4.79f, -2.82f);
            print(transform.position.x);
            boxManager.boxMoved[2] = true;
            spriteRenderer.sortingOrder = boxManager.layerOrder[3];
        }
        else if (boxManager.boxMoved[4])
        {
            transform.position = new Vector2(4.79f, -4.45f);
            print(transform.position.x);
            boxManager.boxMoved[3] = true;
            spriteRenderer.sortingOrder = boxManager.layerOrder[4];
        }
        else if (boxManager.boxMoved[5])
        {
            transform.position = new Vector2(4.79f, -6f);
            print(transform.position.x);
            boxManager.boxMoved[4] = true;
            spriteRenderer.sortingOrder = boxManager.layerOrder[5];
        }
        else
        {
            // Do Nothing.
        }
    }
    private void ReturnBox(int boxNumber)
    {
        boxManager.boxMovedBack[5] = true;
        if (boxManager.boxMovedBack[0])
        {
            avatarController.keyAccess = true;  // Allows user to exit building.  
            transform.position = new Vector2(-2.96f, -1.64f);
            print(transform.position.x);
            boxManager.boxMovedBack[0] = true;
        }
        else if (boxManager.boxMovedBack[1])
        {
            transform.position = new Vector2(-5.57f, -5.25f);
            print(transform.position.x);
            boxManager.boxMovedBack[0] = true;
        }
        else if (boxManager.boxMovedBack[2])
        {
            transform.position = new Vector2(-8.1f, -5.25f);
            print(transform.position.x);
            boxManager.boxMovedBack[1] = true;
        }
        else if (boxManager.boxMovedBack[3])
        {
            transform.position = new Vector2(-2.95f, -5.25f);
            print(transform.position.x);
            boxManager.boxMovedBack[2] = true;
        }
        else if (boxManager.boxMovedBack[4])
        {
            transform.position = new Vector2(-8.1f, -1.64f);
            print(transform.position.x);
            boxManager.boxMovedBack[3] = true;
        }
        else if (boxManager.boxMovedBack[5])
        {
            transform.position = new Vector2(-5.6f, -1.64f);
            print(transform.position.x);
            boxManager.boxMovedBack[4] = true;
        }
        else
        {
            // Do Nothing.
        }
    }
}
