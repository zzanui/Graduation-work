using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    //Start = Ȱ��ȭ �� ������ �Ҹ� / Awake = Ŭ���� ������ó�� ����ϱ�

    //������ �������ֱ�
    void Awake()
    {
        //�ִ� �������� 60���� ����
        Application.targetFrameRate = 60;
    }
}
