using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMove : MonoBehaviour
{

    //HitBox의 거리
    public float HitRangeX = 1;
    public float HitRangeY = 0;


    //ui입력 받아오는 변수
    public bool inputLeft = false;
    public bool inputRight = false;
    public bool inputJump = false;

    //�����
    float xSpeed = 5;
    float jumpHeight = 3;
    float minY = 0; 
    float jumpDuration = 0.5f;

    //��꿡 �ʿ��� ��s
    float jumpTimePassed = 0;
    bool isJumping = false;

    //랜더용 변수
    SpriteRenderer rend;

    //애니메이터 변수
    Animator anim;
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        minY = transform.position.y;
        

        playerMove ui = GameObject.FindGameObjectWithTag("Managers").GetComponent<playerMove>();
        Debug.Log(ui);
        ui.Init();
    }

    // Update is called once per frame
    //������Ʈ�� �����Ӹ���/ �����Ӵ���
    void Update()
    {
        float xMove = Time.deltaTime * xSpeed;

        if (inputLeft)
        {
            //���� - ������ ���� ����3   new Vector3(-1, 0, 0)
            transform.position += xMove * Vector3.left;
            rend.flipX=true;

            //ĳ���� ����
            transform.localScale = new Vector3(0.5f,0.5f,0.5f);

            //히트박스 위치 변경 
            transform.GetChild(0).gameObject.transform.position = transform.position + new Vector3(HitRangeX*(-1),HitRangeY,0);

            anim.SetBool("Walking",true);
        }
        else if (inputRight)
        {
            //������ ���� ����3     new Vector3(1, 0, 0)
            transform.position += xMove * Vector3.right;
            rend.flipX=false;
            //ĳ���� ����
            transform.localScale = new Vector3(0.5f,0.5f,0.5f);

            //히트박스 위치 변경 
            transform.GetChild(0).gameObject.transform.position = transform.position + new Vector3(HitRangeX,HitRangeY,0);

            anim.SetBool("Walking",true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }

        if (inputJump)
        {
            if (!isJumping)
            {
                isJumping = true;
                jumpTimePassed = 0;
                anim.SetBool("Jumping", false);
            }
        }

        if (isJumping)
        {
            jumpTimePassed += Time.deltaTime;
            if(jumpTimePassed < jumpDuration)
            {
                anim.SetBool("Jumping", true);
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
            inputJump = false;
        }
        else
        {
            anim.SetBool("Jumping", false);
        }
    }
    
}
