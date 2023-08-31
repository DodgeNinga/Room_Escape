using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultPlayerController : PlayerController
{

    protected override void Awake()
    {

        base.Awake();

        var playerMove = new PlayerMove(this);
        var playerJump = new PlayerJump(this);
        var cameraRotate = new CameraRotate(this);
        var playerInteraction = new PlayerInteraction(this);
        var playerGrab = new PlayerGrab(this);
        var gravity = new Gravity(transform);

        HashSet<IUpdate> moveStateUpdate = new()
        {

            playerMove,
            playerJump,
            cameraRotate,
            playerInteraction,
            playerGrab,
            inputSystem

        };

        HashSet<IFixedUpdate> moveFixedUpdate = new()
        {

            gravity

        };

        stateUpdateContainer.Add(PlayerState.Move, moveStateUpdate);
        stateFixedUpdateContainer.Add(PlayerState.Move, moveFixedUpdate);

        ChangeState(currentState);

    }

}
