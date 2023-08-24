using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PuzzleBehaviour : MonoBehaviour, IEnable
{

    private PlayerController controller;

    protected PlayerInputSystem input => controller.inputSystem;

    public bool enable { get; set; }

    protected virtual void Awake()
    {

        Enable();

        controller = FindObjectOfType<PlayerController>();

    }

    protected abstract void PuzzleComplete();

    public virtual void Enable()
    {

        enable = true;

    }

    public virtual void Disable()
    {

        enable = false;

    }

}
