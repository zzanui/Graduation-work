using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void leftMove(){
        Debug.Log("왼쪽");
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
