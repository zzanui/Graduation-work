using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMove : MonoBehaviour
{

    //HitBox의 거리
    public float HitRangeX = 1f;
    public float HitRangeY = 0;

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
            transform.GetChild(0).gameObject.transform.position = transform.position + new Vector3(HitRangeX*(-1),HitRangeY,0);  
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            //������ ���� ����3     new Vector3(1, 0, 0)
            transform.position += xMove * Vector3.right;
            rend.flipX=false;
            //ĳ���� ����
            transform.localScale = new Vector3(0.5f,0.5f,0.5f);

            //히트박스 위치 변경 
            transform.GetChild(0).gameObject.transform.position = transform.position + new Vector3(HitRangeX,HitRangeY,0);
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
    //---------------버튼용 함수들-------------------
    void leftMoveButton(){
        transform.position += (Time.deltaTime * xSpeed) * Vector3.left;
            rend.flipX=true;

            //ĳ���� ����
            transform.localScale = new Vector3(0.5f,0.5f,0.5f);

            //히트박스 위치 변경 
            transform.GetChild(0).gameObject.transform.position = transform.position + new Vector3(HitRangeX*(-1),HitRangeY,0);  
    }
    void rightMoveButton(){
        transform.position += (Time.deltaTime * xSpeed) * Vector3.right;
            rend.flipX=false;
            //ĳ���� ����
            transform.localScale = new Vector3(0.5f,0.5f,0.5f);

            //히트박스 위치 변경 
            transform.GetChild(0).gameObject.transform.position = transform.position + new Vector3(HitRangeX,HitRangeY,0);
    }
    void jumpButton(){
        if (!isJumping)
            {
                isJumping = true;
                jumpTimePassed = 0;
            }

            
        

        if (isJumping)
        {
            jumpTimePassed += Time.deltaTime;
            if(jumpTimePassed < jumpDuration)
            {
                
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
