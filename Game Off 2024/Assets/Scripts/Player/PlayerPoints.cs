using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPoints
{
    private float orbs;

    public PlayerPoints(int points) {
        orbs = points;
    }

    public void AddOrbs(float newOrbs) {
        orbs += newOrbs;
    }

    public void SubtractOrbs(float newOrbs) {
        orbs -= newOrbs;
    }

    public void ResetPlayerOrbs() {
        orbs = 0;
    }

    public float GetPlayerPoints() {
        return orbs;
    }
}
