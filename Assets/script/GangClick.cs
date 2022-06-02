using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GangClick : MonoBehaviour
{
    public Text ScriptTxt;

    int Gold = 0;
    // Start is called before the first frame update
    void Start()
    {
        ScriptTxt.text = "0";
    }

    // Update is called once per frame
    public void GoldPuls()
    {
        Gold += 1;
        ScriptTxt.text = Gold.ToString();
    }
}
