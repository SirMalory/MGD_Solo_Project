using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    public float LevelTimer = 10f;
    public bool IsLevelOver = true;
    private float _elapsedCooldownTime;
    public bool _exitingGame = true;

    public GamePlayState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public void Update()
    {
        LeaveState();
    }


    public override void Enter()
    {
        base.Enter();
        Debug.Log("STATE: GAME PLAY");
        _controller._gameplayTrigger.Play();
        StartTimer();
    }

    public override void Exit()
    {
        base.Exit();
        if (_exitingGame == false)
        {
            _stateMachine.ChangeState(_stateMachine.SetupState);
        }
        else
        {
            _stateMachine.ChangeState(_stateMachine.CurrentState);
        }
    }

    public override void FixedTick()
    {
        base.FixedTick();
    }

    public override void Tick()
    {
        base.Tick();
        Debug.Log(_elapsedCooldownTime);

    }

    public void LeaveState()
    {
        if(IsLevelOver == false)
        {
            _elapsedCooldownTime += Time.deltaTime;
            if (_elapsedCooldownTime >= LevelTimer)
            {
                IsLevelOver = true;
                _stateMachine.ChangeState(_stateMachine.SetupState);
            }
        }
    }

    public void StartTimer()
    {
        IsLevelOver = false;
        _elapsedCooldownTime = 0;
    }
}
