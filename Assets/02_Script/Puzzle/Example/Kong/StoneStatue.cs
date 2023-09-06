using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneStatue : PuzzleBehaviour
{
    [SerializeField] private StoneSencer stoneSencer;
    [SerializeField] private Transform stonePos;
    [SerializeField] private Stone stone;

    private void Update()
    {

    }

    public override void OnMouse()
    {
        if (isInteraction) return;

        if (input[KeyCode.E, KeyState.Down])
        {
            Debug.Log("∆€¡Ò ªÛ»£¿€øÎ");

            isInteraction = true;

            PuzzleComplete();

        }
    }

    protected override void PuzzleComplete()
    {
        stone.gameObject.SetActive(true);
        stone.SetOriginPos(stonePos.position);
        stone.Disable();

        Debug.Log("∆€¡Ò ≥°!");

    }

}
