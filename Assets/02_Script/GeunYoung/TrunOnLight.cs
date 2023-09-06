using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrunOnLight : PuzzleBehaviour
{
    public PlayerController player;
    public new Light light;

    private float distance;

    private void Start()
    {
        light.GetComponent<Light>().intensity = 0;
    }

    private void Update()
    {
        CheckDistance();
        OnMouse();
    }

    public override void OnMouse()
    {
        //이미 상호작용 한 상태거나 비활성 상태라면 반환
        if (isInteraction || !enable) return;

        //로그 출력
        Debug.Log("상호작용 대기중");

        if (input[KeyCode.E, KeyState.Down] && distance <= 3)
        {
            //로그 출력
            Debug.Log("퍼즐 상호작용");

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.2f);
            light.GetComponent<Light>().intensity = 130000;

            //상호작용여부 변환
            isInteraction = true;

            //퍼즐 완료 호출
            PuzzleComplete();
        }
    }

    private void CheckDistance()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
    }

    protected override void PuzzleComplete()
    {
        Debug.Log("불을 켰어요!");
    }
}
