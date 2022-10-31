using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float f_jumpForce;

    private float f_rotation;

    public void Awake()
    {
        f_rotation = gameObject.transform.rotation.y;
        Debug.Log(f_rotation);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            /*
            f_rotation += 1.0f;
            gameObject.transform.LookAt(f_rotation);
            Debug.Log(f_rotation);
            */
        }
    }

    void Jump()
    {
        gameObject.GetComponentInChildren<Rigidbody>().AddForce(gameObject.transform.forward * f_jumpForce, ForceMode.Impulse);
    }
}
