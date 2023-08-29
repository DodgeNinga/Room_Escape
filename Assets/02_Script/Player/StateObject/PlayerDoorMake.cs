using AmazingAssets.AdvancedDissolve;
using Parabox.CSG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDoorMake : PlayerRoot
{

    private Transform cameraRootTrm;
    private GameObject doorBooleanObject;
    private AdvancedDissolveKeywordsController dissolveController;

    public PlayerDoorMake(PlayerController controller) : base(controller)
    {
    }

    public override void Awake()
    {

        base.Awake();

        cameraRootTrm = transform.Find("CameraRoot");
        doorBooleanObject = transform.Find("CameraRoot").Find("DoorCube").gameObject;
        dissolveController = transform.Find("MakeDoor").GetComponentInChildren<AdvancedDissolveKeywordsController>();

        dissolveController.state = AdvancedDissolveKeywords.State.Disabled;

    }

    public override void Update()
    {

        if (input[MouseCode.Left, KeyState.Down])
        {

            Debug.Log(123);

            var obj = Physics.BoxCastAll(doorBooleanObject.transform.position, 
                doorBooleanObject.transform.localScale / 2, 
                cameraRootTrm.forward, 
                doorBooleanObject.transform.rotation, 
                Mathf.Infinity, 
                LayerMask.GetMask("CutAble"));

            if(obj.Length != 0)
            {

                foreach(var item in obj)
                {

                    var res = CSG.Subtract(item.transform.gameObject, doorBooleanObject);

                    var newObj = new GameObject();

                    newObj.AddComponent<MeshFilter>().sharedMesh = res.mesh;
                    newObj.AddComponent<MeshCollider>().sharedMesh = res.mesh;
                    newObj.AddComponent<MeshRenderer>().sharedMaterials = res.materials.ToArray();

                    newObj.layer = item.transform.gameObject.layer;

                    //Object.Destroy(item.transform.gameObject);

                }

            }

            controller.ChangeState(PlayerState.Move);

        }

    }

    public override void Enable()
    {

        base.Enable();

        dissolveController.state = AdvancedDissolveKeywords.State.Enabled;

    }

    public override void Disable() 
    { 
        
        base.Disable();

        dissolveController.state = AdvancedDissolveKeywords.State.Disabled;

    }

}
