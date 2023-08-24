using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : PlayerRoot
{

    private float JumpPower => value.jumpPower;

    public PlayerJump(PlayerController controller) : base(controller)
    {
    }

    private void Jump()
    {

        rigid.velocity += Vector3.up * JumpPower;

    }

    public override void Update()
    {

        if (input[KeyCode.Space, KeyState.Down] && isGround)
        {

            Jump();

        }

    }

}
