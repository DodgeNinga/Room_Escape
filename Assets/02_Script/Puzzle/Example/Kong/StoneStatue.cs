using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneStatue : PuzzleBehaviour
{
    [SerializeField] private SencerRoot stoneSencer;
    [SerializeField] private Transform stonePos;
    [SerializeField] private Stone stone;

    private void Update()
    {
        if (!isInteraction) return;

        if (stoneSencer.isDetected)
        {
            isInteraction = true;
            PuzzleComplete();
        }
    }

    public override void OnMouse()
    {
        if (isInteraction) return;
    }

    protected override void PuzzleComplete()
    {
        stone.SetOriginPos(stonePos.position);
        stone.Disable();

        Debug.Log("Puzzle End!!");
    }
}
