using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : IFixedUpdate
{

    private const float gravityValue = 9.81f;

    private CollisionSencer groundSencer;
    private Rigidbody rigid;

    public bool enable { get; set; }

    public Gravity(Transform trm)
    {

        this.groundSencer = trm.Find("GroundSencer").GetComponent<CollisionSencer>();
        rigid = trm.GetComponent<Rigidbody>();

    }

    public void FixedUpdate()
    {

        if(enable && !groundSencer.isDetected)
        {

            rigid.velocity -= Vector3.up * Time.fixedDeltaTime * gravityValue;

        }

    }    

    public void Enable()
    {

        enable = true;

    }

    public void Disable()
    {

        enable = false;

    }

}
