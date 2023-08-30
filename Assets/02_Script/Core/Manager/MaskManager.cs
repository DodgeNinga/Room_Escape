using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskManager : MonoBehaviour
{

    [Header("����ũ ������ ������ ������Ʈ"),SerializeField] private List<GameObject> maskOnObject = new List<GameObject>();
    [Header("����ũ �������� ������ ������Ʈ"),SerializeField] private List<GameObject> maskOffObject = new List<GameObject>();

    public void MaskOn()
    {

        foreach(var item in maskOnObject)
        {

            item.SetActive(true);

        }

    }

}
