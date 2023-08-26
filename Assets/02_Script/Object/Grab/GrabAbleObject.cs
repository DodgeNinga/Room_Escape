using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabAbleObject : MonoBehaviour, IGrab
{

    public PlayerInputSystem input;

    public float objectSize { get; set; }
    public bool grabAble { get; set; }

    private void Start()
    {

        input = FindObjectOfType<PlayerController>().inputSystem;

    }


    public void ChangeTrm(Vector3 pos)
    {

        transform.position = pos;

    }



#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        
        var old = Gizmos.color;
        Gizmos.color = Color.blue;

        Gizmos.DrawWireSphere(transform.position, objectSize);

        Gizmos.color = old;

    }

#endif

}
