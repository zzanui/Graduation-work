using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{

    public GameObject prfHpBar;
    public GameObject canvas;

    RectTransform hpBar;

    public float height = 1.7f;

    void start()
    {
        hpBar = Instantiate(prfHpBar, canvas.transform).GetComponent<RectTransform>();
    }
    void Update1()
    {
        Vector3 _hpBarPos =
            Camera.main.WorldToScreenPoint(new Vector3(transform.position.x, transform.position.y + height, 0));
        hpBar.position = _hpBarPos;
    }

    //--------------------------------------------

    private void Update() {
        if(hp <= 0) {
            Destroy(this.gameObject);
        }
    }
    public int hp = 3;
   public void TakeDamage(int damage) {
        

       hp = hp - damage;
   }




}
