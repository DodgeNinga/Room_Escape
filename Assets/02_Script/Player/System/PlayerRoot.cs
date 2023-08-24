using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRoot : MonoObject
{
    
    protected PlayerController controller;
    protected Rigidbody rigid;
    protected PlayerInputSystem input => controller.inputSystem;

    public PlayerRoot(PlayerController controller) : base(controller.gameObject)
    {

        this.controller = controller;
        rigid = controller.GetComponent<Rigidbody>();

    }

}
