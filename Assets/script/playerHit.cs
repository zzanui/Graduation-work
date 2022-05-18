using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//캐릭터 피격시 색상변환,무적



public class playerHit : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    
    public float invincibility;//무적시간

    public int HP = 10;


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
        if(gameObject.layer == 9 && collision.gameObject.tag == "Enemy"){
            OnDamaged();

            //피격후 무적시간 설정    
            
            
        }
    }

    void OnDamaged(){//피격시 불투명 되는 함수
        gameObject.layer = 11;
        Debug.Log("색상변경");
        //피격시 색상변경
        spriteRenderer.color = new Color(1,1,1,0.4f);
        
        //피격시 hp 감소
        HP -= 1;
        Debug.Log("현재 체력 " + HP + "입니다.");
    

        //딜레이 //무적시간
        Invoke("OffDemaged",invincibility);
    }

    void OffDemaged(){//투명도를 원래대로
        gameObject.layer = 9;
        spriteRenderer.color = new Color(1,1,1,1);

  
        Debug.Log("원래대로");
    }
   
}

