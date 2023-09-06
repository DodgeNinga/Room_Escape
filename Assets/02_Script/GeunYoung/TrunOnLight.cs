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
        //�̹� ��ȣ�ۿ� �� ���°ų� ��Ȱ�� ���¶�� ��ȯ
        if (isInteraction || !enable) return;

        //�α� ���
        Debug.Log("��ȣ�ۿ� �����");

        if (input[KeyCode.E, KeyState.Down] && distance <= 3)
        {
            //�α� ���
            Debug.Log("���� ��ȣ�ۿ�");

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.2f);
            light.GetComponent<Light>().intensity = 130000;

            //��ȣ�ۿ뿩�� ��ȯ
            isInteraction = true;

            //���� �Ϸ� ȣ��
            PuzzleComplete();
        }
    }

    private void CheckDistance()
    {
        distance = Vector3.Distance(player.transform.position, transform.position);
    }

    protected override void PuzzleComplete()
    {
        Debug.Log("���� �׾��!");
    }
}
