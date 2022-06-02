using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator anim;
    SpriteRenderer SpriteRenderer;

    public int nextMove; //다음 행동지표를 결정 할 변수

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        Invoke("Think", 1); // 초기화 함수 안에 넣어서 실행될 떄  마다(최초1회) nextMove변수가 초기화 되도록 함
    }

    
    void FixedUpdate()
    {
        //Move
        rigid.velocity = new Vector2(nextMove, rigid.velocity.y); // nextMove 에 0:멈춤 -1:왼쪽 1:오른쪽 으로 이동

    }

    void Think() //몬스터가 스스로 생각해서 판단 (-1:왼쪽이동, 1:오른쪽 이동, 0:멈춤 으로 3가지 행동을 판단)
    {
        //Set Next Active
        //Random.Range : 최소<= 난수 < 최대 / 범위의 랜덤 수를 생성(최대는 제외이므로 주의)
        
        do {
            nextMove = Random.Range(-1,2);
        }
        while(nextMove == 0);
        //Sprite Animation
        //WalkSpeed변수를 nextMove로 초기화
        anim.SetInteger("WalkSpeed" , nextMove);

        //Flip Sprite
        if(nextMove != 0) // 서있을 때 굳이 방향을 바꿀 필요가 없음
         SpriteRenderer.flipX = nextMove == 1; //nextMove 가 1이면 방향을 반대로 변경

         //Recursive (재귀함수는 가장 아래에 쓰는게 기본적)
        //float nextThinkTime = Random.Range(2f, 5f); // 생각하는 시간을 랜덤으로 부여
        //Think(); : 재귀함수 : 딜레이를 쓰지 않으면 CPU과부화 되므로 재귀함수를 쓸 때는 항상 주의 -> Think()를 직접 호출하는 대신 Invoke() 사용
        Think(); //매개변수로 받은 함수를 time초의 딜레이를 부여하여 재실행
    }

    void Turn()
    {
        nextMove *= -1;
        SpriteRenderer.flipX = nextMove == 1; //우리가 직접 방향을 바꾸어 주었으니 Think는 잠시 멈추어야함

        CancelInvoke(); //think를 잠시 멈춘 후 재실행
        Invoke("Think",2);
    }


}
