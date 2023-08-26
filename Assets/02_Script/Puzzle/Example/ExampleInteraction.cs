using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PuzzleBehaviour�� ��ӹ����� �߻�ɹ��� �����Ѵ�(ALT + Tab)
//������Ʈ�� ���̰� �� ������Ʈ ���̾ �� Interaction���� �����ϱ�
public class ExampleInteraction : PuzzleBehaviour
{

    //ũ�ν��ؾ ������Ʈ�� ��������
    public override void OnMouse()
    {

        //�̹� ��ȣ�ۿ� �� ���°ų� ��Ȱ�� ���¶�� ��ȯ
        if (isInteraction || !enable) return;

        //�α� ���
        Debug.Log("��ȣ�ۿ� �����");

        //EŰ�� ���ȴٸ�?
        if (input[KeyCode.E, KeyState.Down])
        {

            //�α� ���
            Debug.Log("���� ��ȣ�ۿ�");

            //��ȣ�ۿ뿩�� ��ȯ
            isInteraction = true;

            //���� �Ϸ� ȣ��
            PuzzleComplete();

        }

    }

    protected override void PuzzleComplete()
    {

        Debug.Log("���� �Ϸ�");
        Disable();

    }

    public override void Disable()
    {

        //�θ�ü�� Disable ȣ��
        base.Disable();

        StartCoroutine(DestroyCo());

    }

    private IEnumerator DestroyCo()
    {

        yield return new WaitForSeconds(1);
        Destroy(gameObject);

    }

}
