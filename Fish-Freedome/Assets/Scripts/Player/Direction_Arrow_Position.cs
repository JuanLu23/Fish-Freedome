using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction_Arrow_Position : MonoBehaviour
{

    public Transform t_playerPosition;
    public Quaternion q_startingPosition;

    public float f_rotationSpeed;
    public float f_resetRotatioTime;

    private Vector3 v3_arrowPositionTransform;

    // Update is called once per frame
    void Update()
    {
        Arrow_Rotation();
        Arrow_Position();
    }

    void Arrow_Rotation()
    {
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(Vector3.up * f_rotationSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(-Vector3.up * f_rotationSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Rotate(Vector3.right * f_rotationSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Rotate(-Vector3.right * f_rotationSpeed);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            gameObject.transform.rotation = Quaternion.Lerp(transform.rotation, q_startingPosition, Time.deltaTime * f_resetRotatioTime);
        }

    }

    void Arrow_Position()
    {
        v3_arrowPositionTransform.x = t_playerPosition.transform.position.x;
        v3_arrowPositionTransform.z = t_playerPosition.transform.position.z;
        v3_arrowPositionTransform.y = t_playerPosition.transform.position.y + 2.0f;
        this.transform.position = v3_arrowPositionTransform;
    }
}  
