using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : PlayerRoot
{

    private (IGrab, Transform) grabObject;
    private Transform cameraRootTrm;

    private float InteractionRange => value.maxInteractionRange;

    public PlayerGrab(PlayerController controller) : base(controller)
    {
    }

    private void SetGrabObject(IGrab grab, Transform trm)
    {

        grabObject.Item1 = grab;
        grabObject.Item2 = trm;

    }

    public override void Awake()
    {

        base.Awake();

        cameraRootTrm = transform.Find("CameraRoot");

    }

    public override void Update()
    {



    }

    public void TryGrabObject()
    {

        if (Physics.Raycast(cameraRootTrm.position, cameraRootTrm.forward,
            out var obj, InteractionRange, LayerMask.GetMask("Interaction")))
        {

            if (obj.transform.TryGetComponent<IGrab>(out var compo))
            {

                compo.OnGrab();

                SetGrabObject(compo, obj.transform);

            }

        }

    }

    public void TryReleaseGrab()
    {

        grabObject.Item1.OnGrabRelease();
        SetGrabObject(null, null);

    }

}
