using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plates : MonoBehaviour
{
    public int order;

    private bool isPushed = false;

    PressurePlates plates;

    private void Start()
    {
        plates = FindObjectOfType<PressurePlates>();
    }

    public void SetOrder(int num)
    {
        order = num;
    }

    public void ResetPush()
    {
        isPushed = false;
    }

    public void GetPushed()
    {
        isPushed = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPushed)
        {
            GetPushed();
            plates.AddToOrder(order);
        }
    }
}
