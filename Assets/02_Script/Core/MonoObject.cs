using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface IAwake : IEnable
{

    public void Awake();

}

public interface IUpdate : IEnable
{

    public void Update();

}

public interface IFixedUpdate : IEnable
{

    public void FixedUpdate();

}

public interface ILateUpdate : IEnable
{

    public void LateUpdate();

}

public interface IEnable
{

    public bool enable { get; set; }

    public void Enable();
    public void Disable();

}

public class MonoObject : IAwake, IUpdate, ILateUpdate, IFixedUpdate
{

    public MonoObject() { }

    public MonoObject(GameObject rootObj) : this()
    { 
        
        transform = rootObj.transform;
        gameObject = rootObj.gameObject;

        Awake();

    }

    protected Transform transform { get; set; }
    protected GameObject gameObject { get; set; }

    public bool enable { get; set; }

    public virtual void Awake() { }
    public virtual void Update() { }
    public virtual void FixedUpdate() { }
    public virtual void LateUpdate() { }
    public virtual void Enable()
    {

        enable = true;

    }
    public virtual void Disable()
    {

        enable = false;

    }

}