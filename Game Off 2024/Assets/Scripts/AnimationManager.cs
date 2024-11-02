using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] private Animator playerAnims;

    private PlayerController playerController;

    private void Start() {
        playerController = GetComponent<PlayerController>();
    }

    private void Update() {
        // Run
        if (playerController.rb.velocity.x != 0 && playerController.IsGrounded() && !playerController.IsWalled()) {
            playerAnims.SetBool("isRunning", true);
        }
        if(playerController.rb.velocity.x == 0 || !playerController.IsGrounded() || playerController.IsWalled()) {
            playerAnims.SetBool("isRunning", false);
        }

        // Air
        if(!playerController.IsGrounded() && !playerController.IsWalled()) {
            playerAnims.SetBool("IsInAir", true);
        }
        if(playerController.IsGrounded() || playerController.IsWalled()) {
            playerAnims.SetBool("IsInAir", false);
        }
        
        // Walls
        if(playerController.IsWalled()) {
            playerAnims.SetBool("IsOnWall", true);
        }
        if(!playerController.IsWalled()) {
            playerAnims.SetBool("IsOnWall", false);
        }
    }
}
