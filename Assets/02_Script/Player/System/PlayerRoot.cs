using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRoot : MonoObject
{

    private CollisionSencer groundSencer;

    protected Rigidbody rigid;
    protected PlayerValue value;
    protected PlayerController controller;

    protected PlayerInputSystem input => controller.inputSystem;
    protected bool isGround => groundSencer.isDetected;

    public PlayerRoot(PlayerController controller) : base(controller.gameObject)
    {

        this.controller = controller;

    }

    public override void Awake()
    {

        groundSencer = controller.transform.Find("GroundSencer").GetComponent<CollisionSencer>();

        rigid = controller.GetComponent<Rigidbody>();
        value = controller.GetComponent<PlayerValue>();

    }

}
