using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
/* Input: N/A
 * Purpose: This class is used to by BoxController to ensure that boxes are moved to the correct
 * location.  It will also allow the user to return the boxes to the correct location.  
 */
{
    public bool[] boxMoved = new bool[6] { false, false, false, false, false, true };
    public bool[] boxMovedBack = new bool[6] { false, false, false, false, false, true };
    public int[] layerOrder = new int[6] { 1, 2, 3, 4, 5, 6 };
}
