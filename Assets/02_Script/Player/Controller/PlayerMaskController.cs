using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaskController : DefaultPlayerController
{

    protected override void Awake()
    {

        base.Awake();

        var gotoMask = new GotoMaskState(this);
        var playerMask = new PlayerMask(this);

        var maskStateContainer = new HashSet<IUpdate>();

        foreach(var item in stateUpdateContainer[PlayerState.Move])
        {

            maskStateContainer.Add(item);

        }

        stateUpdateContainer[PlayerState.Move].Add(gotoMask);
        maskStateContainer.Add(playerMask);

        stateUpdateContainer.Add(PlayerState.Mask, maskStateContainer);

        ChangeState(currentState);

    }

}
