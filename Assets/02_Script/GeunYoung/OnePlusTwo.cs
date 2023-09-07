using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnePlusTwo : MonoBehaviour
{
    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<SunButton>().SetNum(i);
        }
    }

    public void Diffusion(int num)
    {
        int a = num == 0 ? transform.childCount - 1 : num - 1;
        int b = num == transform.childCount - 1 ? 0 : num + 1;

        transform.GetChild(a).GetComponent<SunButton>().Detected();
        transform.GetChild(b).GetComponent<SunButton>().Detected();
    }
}
