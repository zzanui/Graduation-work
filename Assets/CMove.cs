using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMove : MonoBehaviour
{
    //상수값
    float xSpeed = 3;
    float jumpHeight = 3;
    float minY = 0; 
    float jumpDuration = 0.5f;

    //계산에 필요한 값
    float jumpTimePassed = 0;
    bool isJumping = false;

    private void Start()
    {
        minY = transform.position.y;
    }

    // Update is called once per frame
    //업데이트는 프레임마다/ 프레임단위
    void Update()
    {
        float xMove = Time.deltaTime * xSpeed;

        if (Input.GetKey(KeyCode.A))
        {
            //동작 - 포지션 값이 백터3   new Vector3(-1, 0, 0)
            transform.position += xMove * Vector3.left;

            //캐릭터 방향
            transform.localScale = new Vector3(1, 1, 1);

        }
        if (Input.GetKey(KeyCode.D))
        {
            //포지션 값이 백터3     new Vector3(1, 0, 0)
            transform.position += xMove * Vector3.right;

            //캐릭터 방향
            transform.localScale = new Vector3(-1, 1, 1);
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
                //프로그레스 단위로 계산
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
