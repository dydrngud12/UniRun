using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� ������Ʈ�� ��� �������� �����̴� ��ũ��Ʈ
public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f; // �̵� �ӵ�

    void Update()
    {
        // ���ӿ����� �ƴ϶��
        if (!GameManager.instance.isGameover)
        {
            // �ʴ� speed�� �ӵ��� �������� �����̵�
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            //transform.Translate(Vector3.left * speed * Time.deltaTime, Space.Self);
            //transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            //transform.position = transform.position + (transform.right * -1) * speed * Time.deltaTime;
            //transform.position += (transform.right * -1) * speed * Time.deltaTime;
            //transform.position = transform.position + Vector3.left * speed * Time.deltaTime;
            //transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}
