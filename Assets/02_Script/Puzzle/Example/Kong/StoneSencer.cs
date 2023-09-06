using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSencer : SencerRoot
{
    public bool stonePuzzle = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Stone"))
        {
            isDetected = true;
            stonePuzzle = true;
        }
    }
}
