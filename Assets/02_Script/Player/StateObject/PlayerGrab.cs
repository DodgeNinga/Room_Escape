using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : PlayerRoot
{

    private (IGrab, Transform, Collider, Rigidbody) grabObject;
    private Transform cameraRootTrm;

    private float InteractionRange => value.maxInteractionRange;

    public PlayerGrab(PlayerController controller) : base(controller)
    {
    }

    private void SetGrabObject(IGrab grab, Transform trm, Collider collider, Rigidbody rigid)
    {

        grabObject.Item1 = grab;
        grabObject.Item2 = trm;
        grabObject.Item3 = collider;
        grabObject.Item4 = rigid;

    }

    private void TryGrabObject()
    {

        if (Physics.Raycast(cameraRootTrm.position, cameraRootTrm.forward,
            out var obj, InteractionRange, LayerMask.GetMask("Interaction")))
        {

            if (obj.transform.TryGetComponent<IGrab>(out var compo))
            {

                compo.OnGrab();

                SetGrabObject(compo, obj.transform, obj.collider, obj.rigidbody);

                obj.collider.enabled = false;

            }

        }

    }
    private void TryReleaseGrab()
    {

        grabObject.Item1.OnGrabRelease();
        grabObject.Item3.enabled = true;

        if(grabObject.Item4 != null)
        {

            grabObject.Item4.velocity = Vector3.zero;

        }

        SetGrabObject(null, null, null, null);

    }

    private Vector3 CalculateObjectPos(float objSize)
    {

        var vel = Physics.Raycast(cameraRootTrm.position, cameraRootTrm.forward, out var info, InteractionRange);

        if (vel && info.transform != grabObject.Item2)
        {

            float length = Vector3.Distance(info.point, cameraRootTrm.position);

            return cameraRootTrm.position + (cameraRootTrm.forward * (length - objSize));

        }
        else
        {

            return cameraRootTrm.position + (cameraRootTrm.forward * InteractionRange);

        }

    }

    public override void Awake()
    {

        base.Awake();

        cameraRootTrm = transform.Find("CameraRoot");

    }

    public override void Update()
    {

        if(grabObject.Item1 != null)
        {

            grabObject.Item1.ChangeTrm(CalculateObjectPos(grabObject.Item1.objectSize));


            if (input[MouseCode.Left, KeyState.Up])
            {

                TryReleaseGrab();

            }

        }
        else
        {

            if (input[MouseCode.Left, KeyState.Down])
            {

                TryGrabObject();

            }

        }

    }

}
