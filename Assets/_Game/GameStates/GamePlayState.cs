using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    public GamePlayState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("STATE: GAME PLAY");
        Debug.Log("Inputs?");
        Debug.Log("Display PLAY");
        _controller._gameplayTrigger.Play();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void FixedTick()
    {
        base.FixedTick();
    }

    public override void Tick()
    {
        base.Tick();
        if(_controller.Input.IsTapPressed == true)
        {
            Debug.Log("WIN?");
            //Reload level or change to setup
        }

        if (_controller.Input.IsExitPressed == true)
        {
            Debug.Log("GET OUT");
            SceneManager.LoadScene("MainMenu");
            //Reload level or change to setup
        }


        else if(StateDuration >= _controller.TapLimitDuration)
        {
            //Debug.Log("lose?");
        }


    }
}
