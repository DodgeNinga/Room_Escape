using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : PlayerRoot
{
    public PlayerJump(PlayerController controller) : base(controller)
    {
    }

    public override void Update()
    {

        if (input[KeyCode.Space, KeyState.Down] && isGround)
        {



        }

    }

}
