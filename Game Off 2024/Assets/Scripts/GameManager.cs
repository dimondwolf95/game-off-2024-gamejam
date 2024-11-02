using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool v1 = true;

    private void Update() {
        DemoSwitch();
    }

    void DemoSwitch() {
        if (Input.GetKeyDown(KeyCode.F) && v1) {
            SceneManager.LoadScene("Demo2", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("Demo1");
            v1 = false;
        } else if (Input.GetKeyDown(KeyCode.F) && !v1) {
            SceneManager.LoadScene("Demo1", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("Demo2");
            v1 = true;
        }
    }
}
