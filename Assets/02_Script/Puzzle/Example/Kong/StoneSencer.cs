using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneCencer : SencerRoot
{
    private void OnTriggerEnter(Collider other)
    {
        if(CompareTag("Stone"))
        {
            isDetected = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(CompareTag("Stone"))
        {
            isDetected = true;
        }
    }
}
