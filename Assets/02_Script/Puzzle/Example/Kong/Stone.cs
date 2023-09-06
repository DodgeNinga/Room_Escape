using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : GrabAbleObject, IGrab, IEnable
{
    private Vector3 originPos;
    private float moveValue;
    private Rigidbody rigid;

    public bool enable { get; set; }

    private void Awake()
    {

        originPos = transform.position;
        rigid = GetComponent<Rigidbody>();
        Enable();

    }

    private void Update()
    {

        SinMove();

    }

    private void SinMove()
    {

        if (enable) return;

        transform.position = originPos + new Vector3(0, Mathf.Sin(moveValue) / 8, 0);
        moveValue += Time.deltaTime;

    }

    public void OnGrabRelease()
    {

        originPos = transform.position;
        moveValue = 0;

    }

    public void SetOriginPos(Vector3 pos)
    {

        originPos = pos;
        moveValue = 0;

    }

    public void Enable()
    {

        enable = true;

    }

    public void Disable()
    {

        enable = false;
        rigid.useGravity = false;
        gameObject.layer = 0;

    }
}
