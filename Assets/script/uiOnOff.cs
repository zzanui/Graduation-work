using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiOnOff : MonoBehaviour
{
    //public GameObject uiPenul;
    public void uiOpen(GameObject uiPenul){
       uiPenul.SetActive(true);
       Time.timeScale = 0.0f;  //씬 정지
    }
    public void uiClose(GameObject uiPenul){
        uiPenul.SetActive(false);
        Time.timeScale = 1.0f;  //씬 실행
    }
}
