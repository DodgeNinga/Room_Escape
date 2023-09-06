using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskHoloChange : MonoBehaviour
{

    [SerializeField, Header("���� ���͸���")] private Material originMat;
    [SerializeField, Header("Ȧ�α׷� ���͸���")] private Material holoMat;

    private MeshRenderer meshRenderer;
    private MaskManager maskManager;
    private bool isMaskChanged = true;

    private void Awake()
    {
        
        meshRenderer = GetComponent<MeshRenderer>();
        maskManager = FindObjectOfType<MaskManager>();

    }

    private void Start()
    {

        maskManager.OnMaskChangeHandle += HandleMaskChangeEvent;

    }

    private void HandleMaskChangeEvent()
    {

        isMaskChanged = !isMaskChanged;

        meshRenderer.material = isMaskChanged ?  holoMat : originMat;

    }

    private void OnDisable()
    {
        
        maskManager.OnMaskChangeHandle -= HandleMaskChangeEvent;

    }

}
