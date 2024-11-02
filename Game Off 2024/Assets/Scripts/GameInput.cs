using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class GameInput : MonoBehaviour
{
    public PlayerInputActions player;

    void Start()
    {
        player = new PlayerInputActions();

        player.Player.Enable();
    }

    public float RunInput() {
        //float horizontal = Input.GetAxisRaw("Horizontal");
        float horizontal = player.Player.Move.ReadValue<Vector2>().x;

        return horizontal;
    }
}
