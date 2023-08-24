using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : PlayerRoot
{

    private Transform cameraRoot;
    private float xRotate, yRotate;

    private float LookSensitivity => value.lookSensitivity;
    private float MaxRotate => value.maxRotate;

    public CameraRotate(PlayerController controller) : base(controller)
    {
    }

    private void Rotate()
    {

        xRotate += input["Mouse X", AxisState.Raw] * Time.deltaTime * LookSensitivity;
        yRotate += input["Mouse Y", AxisState.Raw] * Time.deltaTime * LookSensitivity;

        yRotate = Mathf.Clamp(yRotate, -MaxRotate, MaxRotate);

        cameraRoot.transform.eulerAngles = new Vector3(-yRotate, xRotate);
        transform.eulerAngles = new Vector3(0, xRotate);

    }

    public override void Awake()
    {

        base.Awake();

        cameraRoot = transform.Find("CameraRoot");

    }

    public override void Update()
    {

        Rotate();

    }

}
