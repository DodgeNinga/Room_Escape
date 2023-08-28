using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JewelSencer : SencerRoot
{

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Jewel"))
        {

            isDetected = true;

        }

    }

    private void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Jewel"))
        {

            isDetected = true;

        }

    }

}
