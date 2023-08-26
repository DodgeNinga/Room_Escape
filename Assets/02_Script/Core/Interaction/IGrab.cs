using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGrab
{

    public float objectSize { get; set; }

    public void OnGrab() { }
    public void OnGrabRelease() { }

    public void ChangeTrm(Vector3 pos);

}
