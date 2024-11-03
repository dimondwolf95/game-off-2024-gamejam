using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] private Animator playerAnims;

    private PlayerController playerController;

    [SerializeField] GameInput gameInput;

    private void Start() {
        playerController = GetComponent<PlayerController>();
    }

    private void Update() {
        MovementAnims();

        if(Input.GetKeyDown(KeyCode.F)) {
            playerAnims.SetBool("Switch", true);
            StartCoroutine(PlayerInput());
        }
        if(Input.GetKeyUp(KeyCode.F)) {
            playerAnims.SetBool("Switch", false);
        }
    }

    IEnumerator PlayerInput() {
        playerController.speed = 1f;
        playerController.jumpingPower = 0f;
        yield return new WaitForSeconds(0.60f);
        playerController.speed = 14f;
        playerController.jumpingPower = 19;
    }

    void MovementAnims() {
        // Run
        if (playerController.rb.velocity.x != 0 && playerController.IsGrounded() && !playerController.IsWalled()) {
            playerAnims.SetBool("isRunning", true);
        }
        if (playerController.rb.velocity.x == 0 || !playerController.IsGrounded() || playerController.IsWalled()) {
            playerAnims.SetBool("isRunning", false);
        }

        // Air
        if (!playerController.IsGrounded() && !playerController.IsWalled()) {
            playerAnims.SetBool("IsInAir", true);
        }
        if (playerController.IsGrounded() || playerController.IsWalled()) {
            playerAnims.SetBool("IsInAir", false);
        }

        // Walls
        if (playerController.IsWalled() && !playerController.IsGrounded()) {
            playerAnims.SetBool("IsOnWall", true);
        }
        if (!playerController.IsWalled() || playerController.IsGrounded()) {
            playerAnims.SetBool("IsOnWall", false);
        }
    }
}
