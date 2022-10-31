using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody go_playerModel;
    public GameObject go_directionArrow;

    public float f_jumpForce;

    public void Awake()
    {
        /*
        go_playerModel = go_playerModel.transform.Find("Player_Model").GetComponent<Rigidbody>();
        go_directionArrow = go_directionArrow.transform.Find("Arrow_Direction").GetComponent<GameObject>();
        */
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            
        }
    }

    void Jump()
    {
        go_playerModel.AddForce(go_directionArrow.transform.forward * f_jumpForce, ForceMode.Impulse);
    }
}
