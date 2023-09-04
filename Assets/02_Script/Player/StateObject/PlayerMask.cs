using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMask : PlayerRoot
{

    private MaskManager maskManager;

    public PlayerMask(PlayerController controller) : base(controller)
    {
    }

    public override void Awake()
    {

        base.Awake();

        maskManager = Object.FindObjectOfType<MaskManager>();

    }

    public override void Update()
    {

        //¸¶½ºÅ© ¹þ±â
        if (input[KeyCode.E, KeyState.Down])
        {

            controller.ChangeState(PlayerState.Move);

        }

    }

    public override void Enable()
    {

        base.Enable();
        maskManager.MaskOn();

    }

    public override void Disable() 
    { 
        
        base.Disable();
        maskManager.MaskOff();
    
    }

}
