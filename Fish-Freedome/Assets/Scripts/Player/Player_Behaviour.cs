using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behaviour : MonoBehaviour
{
    public Transform t_directionArrow;

    public float f_jumpStrenght;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(t_directionArrow.forward * f_jumpStrenght, ForceMode.Impulse);
    }
}
