using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteraction
{

    /// <summary>
    /// 플레이어가 상호작용을 했는가?
    /// </summary>
    public bool isInteraction { get; set; }

    /// <summary>
    /// 크로스해어에 오브젝트가 들어왔을때 실행되는 메서드
    /// </summary>
    public void OnMouse();

}
