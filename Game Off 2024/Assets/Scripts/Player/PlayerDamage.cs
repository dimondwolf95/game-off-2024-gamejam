using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    PlayerHealth playerHealth;

    PlayerPoints playerPoints;

    private EnemyDamageHolder enemyDamageHolder;

    private void Start() {
        playerHealth = new PlayerHealth(3);
        playerPoints = new PlayerPoints(0);
    }

    void Update() {
        if(playerHealth.GetHealth() == 0) {
            playerPoints.ResetPlayerOrbs();
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
