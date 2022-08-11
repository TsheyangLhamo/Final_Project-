using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    public Slider healthBar;
    public Transform respawnPoint;
    public Health playerHealth;

    private void start()
    {
        healthBar = GetComponent<Slider>();

    }
    private void Update()
    {
        
        print(playerHealth.curHealth);
        if (playerHealth.curHealth <= 0)
        {
            playerHealth.SetHealth(20);
            transform.position = respawnPoint.position;
            healthBar = GetComponent<Slider>();
        }
    }
}
