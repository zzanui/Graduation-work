using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiOnOff : MonoBehaviour
{
    //public GameObject uiPenul;
    public void uiOpen(GameObject uiPenul){
       uiPenul.SetActive(true);
       Debug.Log("uiOpen");
    }
    public void uiClose(GameObject uiPenul){
        uiPenul.SetActive(false);
    }
}
