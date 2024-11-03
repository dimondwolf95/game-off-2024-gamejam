using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject demoV1;
    [SerializeField] GameObject demoV2;

    bool v1 = true;

    private void Update() {
        DemoSwitch();
    }

    void DemoSwitch() {
        if (Input.GetKeyDown(KeyCode.F) && v1) {
            demoV2.SetActive(true);
            demoV1.SetActive(false);
            v1 = false;
        } else if (Input.GetKeyDown(KeyCode.F) && !v1) {
            demoV1.SetActive(true);
            demoV2.SetActive(false);
            v1 = true;
        }
    }
}
