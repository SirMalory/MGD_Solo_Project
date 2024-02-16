using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachineMB : MonoBehaviour
{
    public State CurrentState { get; private set; }
    private State _previousState;

    private bool _inTransition = false;

    public void ChangeState(State newState)
    {
        //Ready for New State
        if (CurrentState == newState || _inTransition)
            return;
        ChangeStateSequence(newState);
    }

    private void ChangeStateSequence(State newState)
    {
        _inTransition = true;
        //Run Exit Before New State
        CurrentState?.Exit();
        StoreStateAsPrevious(newState);

        CurrentState = newState;

        //Begin New EnterSequence
        CurrentState?.Enter();
        _inTransition = false;
    }

    private void StoreStateAsPrevious(State newState)
    {
        //No State?, This is It
        if (_previousState == null && newState != null)
            _previousState = newState;
        //Else, Store State as Last One
        else if (_previousState != null && CurrentState != null)
            _previousState = CurrentState;
    }

    public void ChangeStateToPrevious()
    {
        if (_previousState != null)
            ChangeState(_previousState);
        else
            Debug.LogWarning("NO OLD STATE TO GIVE!");
    }

    protected virtual void Update()
    {
        //Sim Updates in States
        if (CurrentState != null && !_inTransition)
            CurrentState.Tick();
    }

    protected virtual void FixedUpdate()
    {
        //Sim FixUpdates in States
        if (CurrentState != null && !_inTransition)
            CurrentState.FixedTick();
    }

    protected virtual void OnDestroy()
    {
        CurrentState?.Exit();
    }
}
