using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        // 몬스터와 피격하는 판정시
        if(collision.gameObject.tag == "Enemy"){
            


            //플레이어가 몬스터와 피격시 날아가는거 만들기
        }
    }

    
    
}
