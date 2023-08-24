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

        groundSencer = transform.Find("GroundSencer").GetComponent<CollisionSencer>();

        rigid = transform.GetComponent<Rigidbody>();
        value = transform.GetComponent<PlayerValue>();

    }

}
