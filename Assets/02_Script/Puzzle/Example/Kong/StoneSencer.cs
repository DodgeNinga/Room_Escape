using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSencer : SencerRoot
{
    public bool stonePuzzleOn = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Stone"))
        {
            isDetected = true;
            stonePuzzleOn = true;
            Debug.Log("Stone ON");
        }
    }
}
