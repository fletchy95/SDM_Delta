using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayManager : MonoBehaviour
/* Input: N/A
 * Purpose: This class is used by ArrayController to ensure all boxes
 * are moved to position before you can leave the house.  The unlockBox
 * boolean unlocks commands to leave the house.  
 */
{
    public bool[] arrayMoved = new bool[6] { false, false, false, false, false, true };
    public bool unlockBox = false;
}
