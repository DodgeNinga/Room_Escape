using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlates : MonoBehaviour
{
    string order;

    private void Start()
    {
        for(int i = 0; i<transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<Plates>().SetOrder(i);
        }
    }

    public void AddToOrder(int num)
    {
        order += num.ToString();

        Debug.Log(order);
    }

    private void Update()
    {
        if (order.Length >= transform.childCount)
        {

            if (order == "0312")
            {
                Debug.Log("¼º°ø");

                order = "";

                for (int i = 0; i < transform.childCount; i++)
                {
                    transform.GetChild(i).GetComponent<Plates>().GetPushed();
                }
            }
            else
            {
                order = "";

                for (int i = 0; i < transform.childCount; i++)
                {
                    transform.GetChild(i).GetComponent<Plates>().ResetPush();
                }
            }
        }
    }
}
