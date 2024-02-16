using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputBroadcaster : MonoBehaviour
{
    private PlayerInput _playerInput;

    private InputAction _touchPressAction;
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
