using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider healthBar;
    public int curHealth = 100;
    public int maxHealth = 100;


    private void Start()
    {
        healthBar = GetComponent<Slider>();
        
    }

    public void SetHealth(int hp)
    {
        healthBar.value = hp;
        curHealth = hp;
    }

    public void TakeDamage(int hp)
    {
        healthBar.value -= hp;
        curHealth -= hp;
    }

    
}