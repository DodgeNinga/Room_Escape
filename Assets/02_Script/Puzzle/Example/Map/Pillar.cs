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

        //명시적으로 상호작용이 가능하다는걸 나타내는 코드

    }

    protected override void PuzzleComplete()
    {

        //페이드 이밴트

        jewel.SetOriginPos(jewelPos.position);

    }

}
