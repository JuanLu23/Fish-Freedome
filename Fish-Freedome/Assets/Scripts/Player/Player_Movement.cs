using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody go_playerModel;
    public GameObject go_directionArrow;

    public float f_jumpForce;

    private float f_holdDownJumpButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            f_holdDownJumpButton = Time.time;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            float f_holdDownTime = Time.time - f_holdDownJumpButton;
            Jump(f_holdDownTime);
        }
    }

    private float Apply_Jump_Force(float f_holdTime)
    {
        float maxHoldDownTime = 2.0f;
        float holdTimeNormalized = Mathf.Clamp01(f_holdTime / maxHoldDownTime);
        float f_finalJumpForce = holdTimeNormalized * f_jumpForce;
        return f_finalJumpForce;
    }

    void Jump(float f_holdTime) => go_playerModel.AddForce(go_directionArrow.transform.forward * Apply_Jump_Force(f_holdTime), ForceMode.Impulse);
}
