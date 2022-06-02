using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class enumyMove : MonoBehaviour
{
    
    public float speed = 1;//이동속도
    private Transform player;//플레이어 위치를 가져올 변수
    private SpriteRenderer rend;
    private Transform trans;
 
    public void Awake()
    
    {   //플레이어 위치 가져옴
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rend = GetComponent<SpriteRenderer>();
        trans = GetComponent<Transform>();
    }
 
    public void Update()
    {
        float xMove = Time.deltaTime * speed;

        //플레이어가 왼쪽에 있을경우 
        if(transform.position.x < player.transform.position.x){
            rend.flipX = true;
            trans.position += xMove * Vector3.right;//왼쪽으로 전진

        }
        else{
            rend.flipX = false;
            trans.position += xMove * Vector3.left;
        }
    }
}
