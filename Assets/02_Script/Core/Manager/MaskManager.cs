using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class MaskManager : MonoBehaviour
{

    [SerializeField] private List<GameObject> maskObject = new List<GameObject>();
    [SerializeField] private Volume maskVolume;
    [SerializeField] private Image fadeImage;

    private void Awake()
    {

        MaskOff();

    }

    /// <summary>
    /// 플레이어가 마스크를 썼을때
    /// </summary>
    public void MaskOn()
    {

        StartCoroutine(FadeCo(() =>
        {

            foreach (var item in maskObject)
            {

                item.SetActive(true);

            }

            maskVolume.weight = 1.0f;

        }));

    }

    /// <summary>
    /// 플레이어가 마스크를 벗었을때
    /// </summary>
    public void MaskOff()
    {

        StartCoroutine(FadeCo(() =>
        {

            foreach (var item in maskObject)
            {

                item.SetActive(false);

            }

            maskVolume.weight = 0;

        }));

    }

    private IEnumerator FadeCo(Action fadeEvent)
    {

        float per = 0;

        var originColor = Color.black;
        originColor.a = 0;

        while(per < 1)
        {

            per += Time.deltaTime * 2;
            fadeImage.color = Color.Lerp(originColor, Color.black, per);
            yield return null;

        }

        per = 0;
        fadeImage.color = Color.black;

        fadeEvent?.Invoke();

        while(per < 1)
        {

            per += Time.deltaTime * 2;
            fadeImage.color = Color.Lerp(Color.black, originColor, per);
            yield return null;

        }

    }

}
