using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoorMakeController : PlayerController
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
        var gotoDoorMake = new GotoDoorMake(this);
        var playerDoorMake = new PlayerDoorMake(this);

        HashSet<IUpdate> moveStateUpdate = new()
        {

            playerMove,
            playerJump,
            cameraRotate,
            playerInteraction,
            playerGrab,
            gotoDoorMake,
            inputSystem

        };

        HashSet<IFixedUpdate> moveFixedUpdate = new()
        {

            gravity

        };

        HashSet<IUpdate> doorStateUpdate = new()
        {

            playerDoorMake,
            cameraRotate,
            inputSystem

        };

        stateUpdateContainer.Add(PlayerState.Move, moveStateUpdate);
        stateUpdateContainer.Add(PlayerState.DoorMake, doorStateUpdate);
        stateFixedUpdateContainer.Add(PlayerState.Move, moveFixedUpdate);

        ChangeState(currentState);

    }

}
