using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskHoloChange : MonoBehaviour
{

    [SerializeField, Header("���� ���͸���")] private Material originMat;
    [SerializeField, Header("Ȧ�α׷� ���͸���")] private Material holoMat;

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
