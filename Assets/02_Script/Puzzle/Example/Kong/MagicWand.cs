using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicWand : PuzzleBehaviour
{
    [SerializeField]private StoneSencer stoneSencer;
    SpriteRenderer spriteRenderer;
    public Transform[] dotSpot;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        gameObject.SetActive(false);
    }

    private void Update()
    {
        WandOn();
    }

    public override void OnMouse()
    {
        
    }

    protected override void PuzzleComplete()
    {
        
    }

    private void WandOn()
    {
        if (stoneSencer.stonePuzzleOn == true)
        {
            gameObject.SetActive(true);
        }
        else return;
    }

    private void PositionCheck()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            foreach (Transform target in dotSpot)
            {
                float distance = Vector2.Distance(mousePosition, target.position);

                if (distance < 1.0f)
                {
                    Debug.Log("트루를 반환합니다!");
                    return;
                }
            }

            Debug.Log("펄스를 반환합니다.");
        }
    }    
}
