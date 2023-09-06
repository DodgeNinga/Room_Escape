using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBook : PuzzleBehaviour
{
    [SerializeField] private StoneSencer stoneSencer;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {

    }

    public override void OnMouse()
    {
        if (input[KeyCode.E, KeyState.Down])
        {
            Debug.Log("���� ��ȣ�ۿ�");

            isInteraction = true;

            StoneSencerOn();

        }
    }

    protected override void PuzzleComplete()
    {

    }

    private void StoneSencerOn()
    {
        if(stoneSencer.stonePuzzle == false) return;

        if(stoneSencer.stonePuzzle == true)
        {
            gameObject.SetActive(true);
            Debug.Log("BOOK");
        }

    }

}
