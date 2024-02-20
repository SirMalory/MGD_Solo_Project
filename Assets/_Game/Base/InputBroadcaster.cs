using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InputBroadcaster : MonoBehaviour
{
    //public event Action Clicked;

    //public Vector2 TouchScreenPosition { get; private set; }
    //public bool TouchIsHeld { get; private set; }

    void Update()
    {

    }

    private void OnEnable()
    {
        //Clicked.Clicked += OnClicked;
    }

    private void OnDisable()
    {
        //TouchInput.Clicked -= OnClicked;
    }
    //private PlayerInput _playerInput;

    //private InputAction _touchPressAction;
    //private InputAction _touchExitAction;
    //public bool IsTapPressed { get; private set; } = false;
    //public bool IsExitPressed { get; private set; } = false;
    //ADD OTHER INPUT HERE

    // public void Awake()
    //{
    //     _playerInput = GetComponent<PlayerInput>();
    //    _touchPressAction = _playerInput.actions.FindAction("TapAction");
    //    _touchExitAction = _playerInput.actions.FindAction("ExitAction");

    //}

    // public void onEnable()
    // {
    //     _touchPressAction.performed += TouchPressed;
    // }

    // public void OnDisable()
    //{
    //    _touchPressAction.performed -= TouchPressed;
    // }

    // public void TouchPressed(InputAction.CallbackContext context) {
    //     float value = context.ReadValue<float>();
    //     Debug.Log("value");
    // }
    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Mouse0))
    //    {
    //        IsTapPressed = true;
    //    }
    //    else if (Input.GetKeyUp(KeyCode.Mouse0))
    //    {
    //        IsTapPressed = false;
    //    }

    //    if (Input.GetKeyDown(KeyCode.Mouse1))
    //    {
    //        IsExitPressed = true;
    //    }
    //    else if (Input.GetKeyUp(KeyCode.Mouse1))
    //  {
    //    IsExitPressed = false;
    //}
    //
    // if (Input.GetKeyDown(KeyCode.Escape))
    // {
    //    SceneManager.LoadScene("MainMenu");
    //}
    //}
}
