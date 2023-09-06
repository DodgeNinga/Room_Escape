using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskHoloChange : MonoBehaviour
{

    [SerializeField, Header("원래 메터리얼")] private Material originMat;
    [SerializeField, Header("홀로그램 메터리얼")] private Material holoMat;

    private MeshRenderer meshRenderer;
    private bool isMaskChanged;

    private void Awake()
    {
        
        meshRenderer = GetComponent<MeshRenderer>();

    }

    private void HandleMaskChangeEvent()
    {

        if(isMaskChanged)
        {



        }

    }

}
