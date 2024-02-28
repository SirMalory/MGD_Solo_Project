using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//using UnityEngine.SceneManagement;

public class InputBroadcaster : MonoBehaviour
{
    private PlayerInput playerInput;
    private InputAction touchPressAction;
    //private InputAction touchPositionAction;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        touchPressAction = playerInput.actions["TouchPress"];
        //touchPositionAction = playerInput.actions["TouchPosition"];

    }

    private void onEnable()
    {
         touchPressAction.performed += TouchPressed;
    }

    private void onDisable()
    {
        touchPressAction.performed -= TouchPressed;
    }

    private void TouchPressed(InputAction.CallbackContext context) {
         float value = context.ReadValue<float>();
         Debug.Log("NOW");
    }

}
