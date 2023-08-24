using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{

    None = -1,
    Move,
    Die

}

public class PlayerController : MonoBehaviour
{

    private Dictionary<PlayerState, HashSet<IUpdate>> stateUpdateContainer = new();
    private Dictionary<PlayerState, HashSet<IFixedUpdate>> stateFixedUpdateContainer = new();
    private Dictionary<PlayerState, HashSet<ILateUpdate>> stateLateUpdateContainer = new();
    private HashSet<IUpdate> updateContainer = new();
    private HashSet<IFixedUpdate> fixedUpdateContainer = new();
    private HashSet<ILateUpdate> lateUpdateContainer = new();
    private PlayerState currentState = PlayerState.Move;


    public PlayerInputSystem inputSystem { get; private set; }

    private void Awake()
    {
        
        inputSystem = new PlayerInputSystem();

    }

    private void Update()
    {
        
        for(var i = stateUpdateContainer[currentState].GetEnumerator(); i.MoveNext();)
        {

            if (i.Current.enable == false) break;

            i.Current.Update();

        }

    }

    private void FixedUpdate()
    {

        for (var i = stateFixedUpdateContainer[currentState].GetEnumerator(); i.MoveNext();)
        {

            if (i.Current.enable == false) break;

            i.Current.FixedUpdate();

        }

    }

    private void LateUpdate()
    {

        for (var i = stateLateUpdateContainer[currentState].GetEnumerator(); i.MoveNext();)
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
