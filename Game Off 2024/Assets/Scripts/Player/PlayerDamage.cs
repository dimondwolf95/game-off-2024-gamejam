using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    PlayerHealth playerHealth;

    PlayerPoints playerPoints;

    private EnemyDamageHolder enemyDamageHolder;

    [SerializeField] ParticleSystem blood;

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
            // Dealing damage
            enemyDamageHolder = collision.GetComponent<EnemyDamageHolder>();
            playerHealth.Damage(enemyDamageHolder.damageAmount);

            // Polish
            Instantiate(blood, collision.gameObject.transform.position, blood.transform.rotation);
            CinemachineShake.Instance.ShakeCamera(2f, .1f);

            // debug
            Debug.Log(playerHealth.GetHealth());
        }
    }
}
