using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    // Start is called before the first frame update
    
    int fullGauge,gauge;

    public Slider sliderA;
    
    void Awake()
    {
       GameObject.Find("power_Slider");
       fullGauge=100;
       gauge=0;
    }

    // Update is called once per frame
    void Update()
    {
        sliderA.value = (float)fullGauge/gauge;
    }

    public void powerUP_Btn(int value)
    {
       gauge += value;
    }
    public void powerDOUN_Btn(int value)
    {
        gauge -= value;
    }
}
