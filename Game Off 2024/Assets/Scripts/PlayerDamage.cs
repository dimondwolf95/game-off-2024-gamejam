using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    PlayerHealth playerHealth;

    private EnemyDamageHolder enemyDamageHolder;

    private void Start() {
        playerHealth = new PlayerHealth(10);
    }

    void Update() {
        if(playerHealth.GetHealth() == 0) {
            // Player is dead
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Enemy")) {
            enemyDamageHolder = collision.GetComponent<EnemyDamageHolder>();
            playerHealth.Damage(enemyDamageHolder.damageAmount);
            Debug.Log(playerHealth.GetHealth());
        }
    }
}
