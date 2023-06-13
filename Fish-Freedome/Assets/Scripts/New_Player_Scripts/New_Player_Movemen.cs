using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class New_Player_Movemen : MonoBehaviour
{

    private Rigidbody playerRigidbody;
    private New_Player_Stats playerStats;
    private Transform parrentTransform;
    private Rigidbody childrenRigidbody;

    private void Start()
    {
        playerStats = New_Player_Stats.Instance;
        childrenRigidbody = GetComponentInChildren<Rigidbody>();
        //parrentTransform = gameObject.GetComponentInParent<Transform>();
        playerStats.playerJump.performed += Jumped;
        playerRigidbody = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        Vector2 move = playerStats.playerMove.ReadValue<Vector2>();
        
        if (move != Vector2.zero)
        {
            Vector3 force = new Vector3(move.x, 0, move.y);

            childrenRigidbody.AddForce(force * playerStats.playerMovementSpeed * Time.deltaTime, ForceMode.Impulse);
        }

    }

    private void Jumped(InputAction.CallbackContext context)
    {
        if (playerStats.playerIsOnFloor)
        {
            Debug.Log("Floor");
            playerStats.playerIsOnFloor = false;
            childrenRigidbody.velocity += (gameObject.transform.up * playerStats.playerJumpForce);
            Debug.Log(childrenRigidbody.velocity);
            //playerRigidbody.AddForce(GetComponentInParent<Transform>().forward * playerStats.playerJumpForce * Time.deltaTime, ForceMode.Impulse);
        }
    }


}
