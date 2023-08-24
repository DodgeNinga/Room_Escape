using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : PlayerRoot
{

    private float MoveSpeed => value.moveSpeed;

    public PlayerMove(PlayerController controller) : base(controller)
    {
    }

    public override void Update()
    {

        float x = input["Horizontal", AxisState.Raw];
        float y = input["Vertical", AxisState.Raw];

        var xVec = transform.forward * x;
        var yVec = transform.right * y;

        var cerVec = (xVec + yVec).normalized * MoveSpeed;
        cerVec.y = rigid.velocity.y;

        rigid.velocity = cerVec;

    }

}
