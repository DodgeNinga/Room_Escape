using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyState
{

    Down,
    Up,
    Alway

}

public enum AxisState
{

    Default,
    Raw

}

public class PlayerInputSystem : IUpdate
{

    private Dictionary<KeyState, HashSet<(KeyCode, Action)>> inputEvent = new();

    public bool this[KeyCode key, KeyState state]
    {

        get
        {

            if (!enable) return false;

            return state switch
            {

                KeyState.Down => Input.GetKeyDown(key),
                KeyState.Up => Input.GetKeyUp(key),
                KeyState.Alway => Input.GetKey(key),
                _ => false

            };

        }

    }
    public float this[string axisName, AxisState state]
    {

        get
        {

            if (!enable) return 0f;
            else return state switch
            {

                AxisState.Raw => Input.GetAxisRaw(axisName),
                AxisState.Default => Input.GetAxis(axisName),
                _ => 0f

            };

        }

    }
    public bool enable { get; set; }

    public void AddKeyInputEvent(KeyState state, KeyCode keyCode, Action action)
    {

        if(inputEvent.ContainsKey(state))
        {
            
            inputEvent[state].Add((keyCode, action));

        }
        else
        {

            inputEvent.Add(state, new HashSet<(KeyCode, Action)> { (keyCode, action) });

        }

    }

    public void Update()
    {
        
        for(var i = inputEvent.GetEnumerator(); i.MoveNext(); )
        {

            foreach(var item in i.Current.Value)
            {

                if(this[item.Item1, i.Current.Key])
                {

                    item.Item2.Invoke();

                }

            }

        }

    }
    public void Disable()
    {

        enable = false;

    }
    public void Enable()
    {

        enable = true;

    }

}
