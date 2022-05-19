using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    GameObject player;
    CMove playerMoveScript;
    playerAttack playerAttackscript;
    // Start is called before the first frame update
    public void Init(){
        player = GameObject.FindGameObjectWithTag("Player");
        playerMoveScript = player.GetComponent<CMove>();
        playerAttackscript = player.GetComponent<playerAttack>();
    }
    //왼쪽버튼 누르고 있을시
    public void leftDown(){
        playerMoveScript.inputLeft = true;
    }
    //왼쪽버튼 땟을시
    public void leftUp(){
        playerMoveScript.inputLeft = false;
    }
    //오른쪽버튼 누르고 있을시
    public void rightDown(){
        playerMoveScript.inputRight = true;
    }
    //오른쪽버튼 땟을시
    public void rightUp(){
        playerMoveScript.inputRight = false;
    }
    //점프버튼 누를시
    public void jumpClick(){
        playerMoveScript.inputJump = true;
    }
    
    //공격버튼 누를시
    public void attackClick(){
        playerAttackscript.inputAttack = true;
    }
    
}
