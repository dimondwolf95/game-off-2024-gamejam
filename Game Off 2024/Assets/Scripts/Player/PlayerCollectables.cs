using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCollectables : MonoBehaviour
{
    PlayerPoints playerPoints;

    [SerializeField] TextMeshProUGUI pointsText;

    private void Start() {
        playerPoints = new PlayerPoints(0);
    }

    private void Update() {
        pointsText.text = "Score: " + playerPoints.GetPlayerPoints();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Orb")) {
            playerPoints.AddOrbs(1);
            Destroy(collision.gameObject);
        }
    }
}
