using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSencer : SencerRoot
{

    private void OnTriggerEnter(Collider other)
    {
        
        isDetected = true;

    }

    private void OnTriggerStay(Collider other)
    {

        isDetected = true;

    }

    private void OnTriggerExit(Collider other)
    {

        isDetected = false;

    }

}
