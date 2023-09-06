using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrunOnLight : PuzzleBehaviour
{
    public new Light light;
    private void Start()
    {
        light.intensity = 0;
    }
    private void Update()
    {
        OnMouse();
    }
    public override void OnMouse()
    {
        
    }

    protected override void PuzzleComplete()
    {
        light.intensity = 100000;
        Debug.Log("ºÒÀ» Ä×¾î¿ä!");
    }
}
