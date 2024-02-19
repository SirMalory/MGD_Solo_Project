using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InputBroadcaster : MonoBehaviour
{
    private PlayerInput _playerInput;

    private InputAction _touchPressAction;
    private InputAction _touchExitAction;
    public bool IsTapPressed { get; private set; } = false;
    public bool IsExitPressed { get; private set; } = false;
    //ADD OTHER INPUT HERE

    public void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _touchPressAction = _playerInput.actions["Shoot"];
        _touchExitAction = _playerInput.actions["Exit"];

    }

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

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            IsExitPressed = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            IsExitPressed = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
