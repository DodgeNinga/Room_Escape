using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoDoorMake : PlayerRoot
{
    public GotoDoorMake(PlayerController controller) : base(controller)
    {
    }

    public override void Update()
    {

        if (input[KeyCode.E, KeyState.Down])
        {

            controller.ChangeState(PlayerState.DoorMake);

        }

    }

}
