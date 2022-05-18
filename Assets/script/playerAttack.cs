using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rigid;
    [SerializeField]
    public float speed; //뭔지 확인해보자
  
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
            if(Input.GetKey(KeyCode.M)){
                Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(pos.position,boxSize,0);
                foreach (Collider2D collider in collider2Ds)
                {
                    if(collider.tag == "Enemy"){
                        Debug.Log("공격!");
                        collider.GetComponent<Enemy>().TakeDamage(1);
                    }
                    
                }
                curTime = coolTime;
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
