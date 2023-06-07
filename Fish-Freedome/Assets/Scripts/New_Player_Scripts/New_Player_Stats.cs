using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class New_Player_Stats : MonoBehaviour
{
    public static New_Player_Stats Instance;

    public InputManager inputManager;

    public InputAction playerMove;
    public InputAction arrowRotation;
    public InputAction playerJump;
    public InputAction pauseGame;

    public LayerMask floorLayer;
    public LayerMask waterLayer;
        
    public float playerHealth;
    public float playerMovementSpeed;
    public float playerJumpForce;

    public bool playerIsOnFloor;

    private void Awake()
    {
        inputManager = new InputManager();

        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        playerMove = inputManager.Player_Actions.PlayerMovement;
        playerMove.Enable();

        arrowRotation = inputManager.Player_Actions.ArrowRotation;
        arrowRotation.Enable();

        playerJump = inputManager.Player_Actions.Jump;
        playerJump.Enable();

        pauseGame = inputManager.UI_Actions.Pause_Game;
        pauseGame.Enable();
    }

    private void OnDisable()
    {
        playerMove.Disable();
        arrowRotation.Disable();
        playerJump.Disable();
        pauseGame.Disable();
    }

}
