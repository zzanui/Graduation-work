using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rigid;
    [SerializeField]
    public float speed;  

  
    void Start()
    {
        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //일단 m키로 공격
    }
}
