using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : PlayerRoot
{

    private Transform cameraRootTrm;

    private float InteractionRange => value.maxInteractionRange;

    public PlayerInteraction(PlayerController controller) : base(controller)
    {
    }

    public override void Awake()
    {

        base.Awake();

        cameraRootTrm = transform.Find("CameraRoot");

    }

    public override void Update()
    {

        if (Physics.Raycast(cameraRootTrm.position, cameraRootTrm.forward,
            out var obj, InteractionRange, LayerMask.GetMask("Interaction")))
        {

            if(obj.transform.TryGetComponent<IInteraction>(out var compo))
            {

                compo.OnMouse();

            }

        }

    }

}
