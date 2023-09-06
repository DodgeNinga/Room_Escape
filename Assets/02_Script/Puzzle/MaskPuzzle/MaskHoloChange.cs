using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskHoloChange : MonoBehaviour
{

    [SerializeField, Header("원래 메터리얼")] private Material originMat;
    [SerializeField, Header("홀로그램 메터리얼")] private Material holoMat;

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
