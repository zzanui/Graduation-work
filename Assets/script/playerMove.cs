using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    GameObject player;
    CMove playerScript;
    // Start is called before the first frame update
    public void Init(){
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<CMove>();
    }

    public void leftMove(){
        //playerScript.
    }
    public void rightMove(){
        Debug.Log("오른쪽");
    }
    public void jumpMove(){
        Debug.Log("점프");
    }
    public void attackMove(){
        Debug.Log("공격");
    }
    
}
