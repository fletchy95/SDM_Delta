using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour
{
    public float speed = 10f;
    public float spriteSwitch = .5f;
    public Sprite upFace;
    public Sprite upFace2;
    public Sprite downFace;
    public Sprite downFace2;
    public Sprite leftFace;
    public Sprite leftFace2;
    public Sprite rightFace;
    public Sprite rightFace2;
    public Sprite stationaryDown;
    public Sprite stationaryUp;
    public Sprite stationaryLeft;
    public Sprite stationaryRight;
    public int savedDirection = 1;      // Test value to see what stationary Sprite to load.  
    public bool canMove = true;         // Used by DialogueManager.  User can almways move, unless in conversation.  
    public bool keyAccess = false;      // Used by BoxController.  Allows user to exit building once level complete.  
    public bool inArea = false;         // Used to test if user is in a specific area.  
    void Start ()
    {
        // Do Nothing. 
    }
	void Update ()
    // Updates once per frame.  
    {
        Controller();
    }

    void Controller()
    /* Inputs: Arrow Keys
     * Purpose: It will determine the direction of the avatar and what 
     * script to load for the avatar.  User will only be able to move
     * while NOT in a conversation.  
     */
    {
        if (canMove)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
                LookRight();
                savedDirection = 4;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                LookLeft();
                savedDirection = 3;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
                LookUp();
                savedDirection = 2;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
                LookDown();
                savedDirection = 1;
            }
            else
            {
                // Whenever user is not moving.  
                Stationary(savedDirection);
            }
        }
    }
    private void LookUp()
    /* Input: N/A (Only ran from Controller method)
     * Purpose: All Look methods (LookUp, LookDown, LookRight, LookLeft, Stationary
     * are to determine what sprite shall be loaded on to the avatar when pressing 
     * the arrow keys. 
     */
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (Random.value < spriteSwitch)
        {
            spriteRenderer.sprite = upFace;
        }
        else
        {
            spriteRenderer.sprite = upFace2;
        }
    }
    private void LookDown()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (Random.value < spriteSwitch)
        {
            spriteRenderer.sprite = downFace;
        }
        else
        {
            spriteRenderer.sprite = downFace2;
        }
    }
    private void LookLeft()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (Random.value < spriteSwitch)
        {
            spriteRenderer.sprite = leftFace;
        }
        else
        {
            spriteRenderer.sprite = leftFace2;
        }
    }
    private void LookRight()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (Random.value < spriteSwitch)
        {
            spriteRenderer.sprite = rightFace;
        }
        else
        {
            spriteRenderer.sprite = rightFace2;
        }
    }
    public void Stationary(int savedDirection)
    /* Input: N/A (Only ran from Controller method)
     * Purpose: Similar to all other Look methods.  However this run only runs when
     * user is stationary.  It takes the saved value of the previously ran direction
     * and faces the user towards that direction, in a stationary stance.  
     */
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (savedDirection == 1)
        {
            spriteRenderer.sprite = stationaryDown;
        }
        else if(savedDirection == 2)
        {
            spriteRenderer.sprite = stationaryUp;
        }
        else if(savedDirection ==3)
        {
            spriteRenderer.sprite = stationaryLeft;
        }
        else
        {
            spriteRenderer.sprite = stationaryRight;
        }
    }
}