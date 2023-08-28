using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{

    None = -1,
    Move,
    DoorMake,
    Die

}

public class PlayerController : MonoBehaviour
{

    protected Dictionary<PlayerState, HashSet<IUpdate>> stateUpdateContainer = new();
    protected Dictionary<PlayerState, HashSet<IFixedUpdate>> stateFixedUpdateContainer = new();
    protected Dictionary<PlayerState, HashSet<ILateUpdate>> stateLateUpdateContainer = new();
    protected HashSet<IUpdate> updateContainer = new();
    protected HashSet<IFixedUpdate> fixedUpdateContainer = new();
    protected HashSet<ILateUpdate> lateUpdateContainer = new();
    protected PlayerState currentState = PlayerState.Move;

    public PlayerInputSystem inputSystem { get; private set; }

    protected virtual void Awake()
    {

        inputSystem = new PlayerInputSystem();

    }

    private void Update()
    {
        
        for(var i = updateContainer.GetEnumerator(); i.MoveNext();)
        {

            if (i.Current.enable == false) break;

            i.Current.Update();

        }

    }

    private void FixedUpdate()
    {

        for (var i = fixedUpdateContainer.GetEnumerator(); i.MoveNext();)
        {

            if (i.Current.enable == false) break;

            i.Current.FixedUpdate();

        }

    }

    private void LateUpdate()
    {

        for (var i = lateUpdateContainer.GetEnumerator(); i.MoveNext();)
        {

            if (i.Current.enable == false) break;

            i.Current.LateUpdate();

        }

    }

    public void ChangeState(PlayerState state)
    {

        for (var i = updateContainer.GetEnumerator(); i.MoveNext();) 
        { 
            
            i.Current.Disable();
        
        }
        for (var i = fixedUpdateContainer.GetEnumerator(); i.MoveNext();)
        {

            i.Current.Disable();

        }
        for (var i = lateUpdateContainer.GetEnumerator(); i.MoveNext();)
        {

            i.Current.Disable();

        }

        if (stateUpdateContainer.ContainsKey(state))
        {

            updateContainer = stateUpdateContainer[state];

        }
        else
        {

            updateContainer = new();

        }

        if (stateFixedUpdateContainer.ContainsKey(state))
        {

            fixedUpdateContainer = stateFixedUpdateContainer[state];

        }
        else
        {

            fixedUpdateContainer = new();

        }

        if (stateLateUpdateContainer.ContainsKey(state))
        {

            lateUpdateContainer = stateLateUpdateContainer[state];

        }
        else
        {

            lateUpdateContainer = new();

        }

        for (var i = updateContainer.GetEnumerator(); i.MoveNext();)
        {

            i.Current.Enable();

        }
        for (var i = fixedUpdateContainer.GetEnumerator(); i.MoveNext();)
        {

            i.Current.Enable();

        }
        for (var i = lateUpdateContainer.GetEnumerator(); i.MoveNext();)
        {

            i.Current.Enable();

        }

        currentState = state;
        
    }

}
