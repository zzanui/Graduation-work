using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
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
