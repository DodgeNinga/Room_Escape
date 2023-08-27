using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : PuzzleBehaviour
{

    [SerializeField] private CollisionSencer jewelSencer;
    [SerializeField] private Transform jewelPos;
    [SerializeField] private Jewel jewel;

    private void Update()
    {

        if (jewelSencer.isDetected)
        {

            isInteraction = true;
            PuzzleComplete();

        }

    }

    public override void OnMouse()
    {

        if (isInteraction) return;

        //��������� ��ȣ�ۿ��� �����ϴٴ°� ��Ÿ���� �ڵ�

    }

    protected override void PuzzleComplete()
    {

        //���̵� �̹�Ʈ

        jewel.SetOriginPos(jewelPos.position);

    }

}
