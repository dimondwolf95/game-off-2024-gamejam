using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCollectables : MonoBehaviour
{
    PlayerPoints playerPoints;

    [SerializeField] TextMeshProUGUI pointsText;
    [SerializeField] GameObject greyedOrb;
    [SerializeField] ParticleSystem orblosion;

    private void Start() {
        playerPoints = new PlayerPoints(0);
    }

    private void Update() {
        pointsText.text = "Score: " + playerPoints.GetPlayerPoints();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Orb")) {
            playerPoints.AddOrbs(1);
            Instantiate(orblosion, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Instantiate(greyedOrb, collision.gameObject.transform.position, Quaternion.identity);
        }
    }
}
