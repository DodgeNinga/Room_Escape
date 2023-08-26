using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PuzzleBehaviour : MonoBehaviour, IEnable, IInteraction
{

    private PlayerController controller;

    /// <summary>
    /// �÷��̾ �Է��� ���� �� �ִ��� �Ǵ��Ͽ� Ű �Է��� �޴� Ŭ����
    /// </summary>
    protected PlayerInputSystem input => controller.inputSystem;

    public bool isInteraction { get; set; }
    public bool enable { get; set; }

    /// <summary>
    /// ���� ���Ḧ �����ؾ��ϴ� �޼���
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
