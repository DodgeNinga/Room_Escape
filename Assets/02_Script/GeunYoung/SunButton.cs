using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunButton : PuzzleBehaviour

{
    public bool isLightOn = false;
    public int num;

    public Material notPushedColor;
    public Material pushedColor;

    public PlayerController player;

    private float distance;

    private void Update()
    {
        CheckDistance();
        OnMouse();
    }
    public override void OnMouse()
    {
        if (isInteraction || !enable) return;


        if (input[KeyCode.E, KeyState.Down] && distance <= 3)
        {
            Detected();
            FindObjectOfType<OnePlusTwo>().GetComponent<OnePlusTwo>().Diffusion(num);
        }
    }
    private void CheckDistance()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
    }

    public void SetNum(int a)
    {
        num = a;
    }

    public void Detected()
    {
        if (isLightOn)
        {
            isLightOn = false;
            transform.GetComponent<MeshRenderer>().material = notPushedColor;
        }
        else
        {
            isLightOn = true;
            transform.GetComponent<MeshRenderer>().material = pushedColor;
        }
    }

    protected override void PuzzleComplete()
    {
        throw new System.NotImplementedException();
    }

}
