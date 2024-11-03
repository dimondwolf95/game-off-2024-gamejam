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

    float amplitude = 1f;
    float time = 0.60f;

    private void Update() {
        DemoSwitch();
    }

    void DemoSwitch() {
        if (Input.GetKeyDown(KeyCode.F) && v1) {
            StartCoroutine(WaitForAnim1());

            CinemachineShake.Instance.ShakeCamera(amplitude, time);
        } else if (Input.GetKeyDown(KeyCode.F) && !v1) {
            StartCoroutine(WaitForAnim2());

            CinemachineShake.Instance.ShakeCamera(amplitude, time);
        }
    }

    IEnumerator WaitForAnim1() {
        yield return new WaitForSeconds(time);
        demoV2.SetActive(true);
        demoV1.SetActive(false);
        v1 = false;
    }

    IEnumerator WaitForAnim2() {
        yield return new WaitForSeconds(time);
        demoV1.SetActive(true);
        demoV2.SetActive(false);
        v1 = true;
    }
}
