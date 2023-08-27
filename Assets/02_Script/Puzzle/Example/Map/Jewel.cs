using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jewel : GrabAbleObject, IGrab
{

    private Vector3 originPos;
    private float moveValue;
    private bool moveAble = true;

    private void Awake()
    {
        
        originPos = transform.position;

    }

    private void Update()
    {

        SinMove();

    }

    private void SinMove()
    {

        if (!moveAble) return;

        transform.position = originPos + new Vector3(0, Mathf.Sin(moveValue), 0);

        moveValue += Time.deltaTime;

    }

    public void OnGrab()
    {

        moveAble = false;

    }

    public void OnGrabRelease() 
    {
    
        moveAble = true;
        originPos = transform.position;
        moveValue = 0;

    }

    public void SetOriginPos(Vector3 pos)
    {

        originPos = pos;
        moveValue = 0;

    }

}
