using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerHit : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Color halfA = new Color(1,1,1,0.5f);
    Color fullA = new Color(1,1,1,1);
    // Start is called before the first frame update
    void Start()
    {
      spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        // 몬스터와 피격하는 판정시
        if(collision.gameObject.tag == "Enemy"){
            OnDamaged();

            //플레이어가 몬스터와 피격시 날아가는거 만들기
        }
    }

    void OnDamaged(){//
        
        gameObject.layer = 3;
        Debug.Log("색상변경");
        //피격시 색상변경
        
        spriteRenderer.color=halfA;
        
        

        //피격시 튕겨나감
    }
    
    
}
