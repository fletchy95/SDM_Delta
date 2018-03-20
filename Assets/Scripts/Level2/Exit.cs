using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    private ArrayManager arrayManager;
    private AvatarController avatarController;
    private void Start()
    {
        arrayManager = FindObjectOfType<ArrayManager>();
        avatarController = FindObjectOfType<AvatarController>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    /* Input: Collider (Avatar)
     * Purpose: Will allow user to exit building if conditions are satisfied. 
     * OnTriggerStay2D does a similar task but allows it to run while user 
     * stays in box not just on enter.  
     */
    {
        avatarController.inArea = true;
        if(Input.GetKey(KeyCode.O))
        {
            if (arrayManager.unlockBox)
            {
                avatarController.keyAccess = true;
            }
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(avatarController.inArea)
        {
            if (Input.GetKey(KeyCode.O))
            {
                if (arrayManager.unlockBox)
                {
                    avatarController.keyAccess = true;
                }
            }
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    /* Input: Collider (Avatar)
     * Purpose: Locks the trigger event.  If user did not
     * press O while inside the user will not be able to leave.  
     */
    {
        avatarController.inArea = false;
    }
}
