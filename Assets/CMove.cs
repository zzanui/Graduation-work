using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMove : MonoBehaviour
{
    //�����
    float xSpeed = 3;
    float jumpHeight = 3;
    float minY = 0; 
    float jumpDuration = 0.5f;

    //��꿡 �ʿ��� ��
    float jumpTimePassed = 0;
    bool isJumping = false;

    private void Start()
    {
        minY = transform.position.y;
    }

    // Update is called once per frame
    //������Ʈ�� �����Ӹ���/ �����Ӵ���
    void Update()
    {
        float xMove = Time.deltaTime * xSpeed;

        if (Input.GetKey(KeyCode.A))
        {
            //���� - ������ ���� ����3   new Vector3(-1, 0, 0)
            transform.position += xMove * Vector3.left;

            //ĳ���� ����
            transform.localScale = new Vector3(0.5f,0.5f,0.5f);

        }
        if (Input.GetKey(KeyCode.D))
        {
            //������ ���� ����3     new Vector3(1, 0, 0)
            transform.position += xMove * Vector3.right;

            //ĳ���� ����
            transform.localScale = new Vector3(0.5f,0.5f,0.5f);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!isJumping)
            {
                isJumping = true;
                jumpTimePassed = 0;
            }

            
        }

        if (isJumping)
        {
            jumpTimePassed += Time.deltaTime;
            if(jumpTimePassed < jumpDuration)
            {
                //���α׷��� ������ ���
                float progress = Mathf.Clamp01(jumpTimePassed / jumpDuration);
                float currentY = Mathf.Sin(Mathf.PI * progress) * jumpHeight;
                Vector3 xzPos = transform.position;
                xzPos.y = minY + currentY;
                transform.position = xzPos;
            }
            else
            {
                isJumping = false;
                Vector3 xzPos = transform.position;
                xzPos.y = minY;
                transform.position = xzPos;
            }
            
            

        }
    }
}
