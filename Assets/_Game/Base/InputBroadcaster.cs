using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBroadcaster : MonoBehaviour
{
    public bool IsTapPressed { get; private set; } = false;
    //ADD OTHER INPUT HERE

    private void Update()
    {
        //INPUT/DETECTION HERE, DOES NOT ACCCOUNT NEW INPUT SYSTEM
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            IsTapPressed = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            IsTapPressed = false;
        }
    }
}
