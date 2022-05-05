using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    //Start = 활성화 될 시점에 불림 / Awake = 클래스 생성자처럼 사용하기

    //프레임 고정해주기
    void Awake()
    {
        //최대 프레임을 60으로 고정
        Application.targetFrameRate = 60;
    }
}
