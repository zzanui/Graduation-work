using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField] float setTime = 10.0f;
    [SerializeField] Text countdownText;

    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        countdownText.text = setTime.ToString();
    }

    public void uiOpen(GameObject uiPenul){
       uiPenul.SetActive(true);

    }
    public void uiClose(GameObject uiPenul){
        uiPenul.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       

        if(setTime > 0)
            setTime -= Time.deltaTime;
        else if (setTime <= 0) {
            uiOpen(panel);
        }

        countdownText.text = Mathf.Round(setTime).ToString();
    }
    
}
