using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetupState : State
{

    private GameFSM _stateMachine;
    private GameController _controller;
    public Unit _unit;

    public bool _exitingGame = true;

    //Constructor, Called on State Creation
    public GameSetupState(GameFSM stateMachine, GameController controller)
    {
        //Hold Parameters for Reuse
        _stateMachine = stateMachine;
        _controller = controller;
    }



    public override void Enter()
    {
        base.Enter();

        Debug.Log("STATE: GAME SETUP");
        _controller._setupTrigger.Play();
        _controller.UnitSpawner.Spawn();
    }

    public override void Exit()
    {
        base.Exit();
        if (_exitingGame == false)
        {
            _stateMachine.ChangeState(_stateMachine.PlayState);
        }
        else
        {
            _stateMachine.ChangeState(_stateMachine.CurrentState);
        }
        //_stateMachine.ChangeState(_stateMachine.PlayState);
    }

    public override void FixedTick()
    {
        base.FixedTick();
    }

    public override void Tick()
    {
        base.Tick();
        //_stateMachine.ChangeState(_stateMachine.PlayState);
    }
}
