using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PuzzleBehaviour : MonoBehaviour, IEnable, IInteraction
{

    private PlayerController controller;

    /// <summary>
    /// 플레이어가 입력을 받을 수 있는지 판단하여 키 입력을 받는 클래스
    /// </summary>
    protected PlayerInputSystem input => controller.inputSystem;

    public bool isInteraction { get; set; }
    public bool enable { get; set; }

    /// <summary>
    /// 퍼즐 종료를 구현해야하는 메서드
    /// </summary>
    protected abstract void PuzzleComplete();

    public abstract void OnMouse();


    protected virtual void Awake()
    {

        Enable();

        controller = FindObjectOfType<PlayerController>();

    }


    public virtual void Enable()
    {

        enable = true;

    }

    public virtual void Disable()
    {

        enable = false;

    }

}
