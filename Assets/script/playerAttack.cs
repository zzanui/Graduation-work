using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rigid;
    [SerializeField]
    public float speed; //뭔지 확인해보자
  
    //공격입력신호 변수
    public bool inputAttack = false;    

    void Start()
    {
        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }

    private float curTime;
    public float coolTime = 0.5f;//공격 딜레이 시간
    public Transform pos;
    public Vector2 boxSize;
    void Update()
    {
        if(curTime <= 0){
            //공격
            //M버튼 클릭시
            if(inputAttack){
                //공격범위를 초기화

                //박스범위 내의 모든 오브젝트를 가져옴
                Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(pos.position,boxSize,0);
                

                foreach (Collider2D collider in collider2Ds)
                {   //가져온 오브젝트가 
                    if(collider.tag == "Enemy"){
                        Debug.Log("공격!");
                        collider.GetComponent<Enemy>().TakeDamage(1);
                    }
                    
                }
                curTime = coolTime;

                //공격 동작이 끝난 후 입력신호를 없음으로
                inputAttack = false;
                animator.SetBool("Attack", true);
            }
            else
            {
                animator.SetBool("Attack", false);
            }
        }
        else
        {
            curTime -= Time.deltaTime;
        }
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(pos.position,boxSize);
        
    }
}
