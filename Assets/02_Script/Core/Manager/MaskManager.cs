using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskManager : MonoBehaviour
{

    [Header("마스크 썼을때 나오는 오브젝트"),SerializeField] private List<GameObject> maskOnObject = new List<GameObject>();
    [Header("마스크 벗엇을때 나오는 오브젝트"),SerializeField] private List<GameObject> maskOffObject = new List<GameObject>();

    public void MaskOn()
    {

        foreach(var item in maskOnObject)
        {

            item.SetActive(true);

        }

    }

}
