using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PuzzleBehaviour를 상속받은후 추상맴버를 구현한다(ALT + Tab)
//오브젝트에 붙이고 그 오브젝트 레이어를 꼭 Interaction으로 변경하기
public class ExampleInteraction : PuzzleBehaviour
{

    //크로스해어에 오브젝트가 들어왔을때
    public override void OnMouse()
    {

        //이미 상호작용 한 상태거나 비활성 상태라면 반환
        if (isInteraction || !enable) return;

        //로그 출력
        Debug.Log("상호작용 대기중");

        //E키가 눌렸다면?
        if (input[KeyCode.E, KeyState.Down])
        {

            //로그 출력
            Debug.Log("퍼즐 상호작용");

            //상호작용여부 변환
            isInteraction = true;

            //퍼즐 완료 호출
            PuzzleComplete();

        }

    }

    protected override void PuzzleComplete()
    {

        Debug.Log("퍼즐 완료");
        Disable();

    }

    public override void Disable()
    {

        //부모객체의 Disable 호출
        base.Disable();

        StartCoroutine(DestroyCo());

    }

    private IEnumerator DestroyCo()
    {

        yield return new WaitForSeconds(1);
        Destroy(gameObject);

    }

}
