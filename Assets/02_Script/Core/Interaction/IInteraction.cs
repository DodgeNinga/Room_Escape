using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteraction
{

    /// <summary>
    /// �÷��̾ ��ȣ�ۿ��� �ߴ°�?
    /// </summary>
    public bool isInteraction { get; set; }

    /// <summary>
    /// ũ�ν��ؾ ������Ʈ�� �������� ����Ǵ� �޼���
    /// </summary>
    public void OnMouse();

}
