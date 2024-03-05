using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameController))]
public class GameFSM : StateMachineMB
{
    private GameController _controller;
    //Variables
    public GameSetupState SetupState { get; private set; }
    public GamePlayState PlayState { get; private set; }


    private void Awake()
    {
        _controller = GetComponent<GameController>();
        //Instantiation Here, but Wont Accept NEW for some reason
        SetupState = new GameSetupState(this,_controller);
        PlayState = new GamePlayState(this,_controller);
        Debug.Log("FSM Functional");
    }

    private void Start()
    {
        ChangeState(SetupState);
    }

    public void ChangeState()
    {
        ChangeState(PlayState);
    }
}
