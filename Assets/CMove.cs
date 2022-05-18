using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMove : MonoBehaviour
{

    //HitBox의 거리
    public float HitRange = 1f;

    //�����
    float xSpeed = 3;
    float jumpHeight = 3;
    float minY = 0; 
    float jumpDuration = 0.5f;

    //��꿡 �ʿ��� ��s
    float jumpTimePassed = 0;
    bool isJumping = false;

    //랜더용 변수
    SpriteRenderer rend;

    private void Start()
    {
        

        minY = transform.position.y;
        rend = GetComponent<SpriteRenderer>();
        
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
            rend.flipX=true;

            //ĳ���� ����
            transform.localScale = new Vector3(0.5f,0.5f,0.5f);

            //히트박스 위치 변경 
            transform.GetChild(0).gameObject.transform.position = transform.position + new Vector3(HitRange*(-1),0f,0f);  
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            //������ ���� ����3     new Vector3(1, 0, 0)
            transform.position += xMove * Vector3.right;
            rend.flipX=false;
            //ĳ���� ����
            transform.localScale = new Vector3(0.5f,0.5f,0.5f);

            //히트박스 위치 변경 
            transform.GetChild(0).gameObject.transform.position = transform.position + new Vector3(HitRange,0f,0f);
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
