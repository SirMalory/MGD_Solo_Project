using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetupState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

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
        Debug.Log("SETTING UP");
        Debug.Log("SPAWN UNITS IN SETUP");
        _controller._setupTrigger.Play();
        _controller.UnitSpawner.Spawn(_controller.PlayerUnitPrefab,
            _controller.PlayerUnitSpawnLocation);
 
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
        _stateMachine.ChangeState(_stateMachine.PlayState);
    }
}
