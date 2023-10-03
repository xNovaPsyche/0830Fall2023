using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchController : MonoBehaviour
{

    public float CrouchHeight = 0.5f;
    public float CrouchSmoothTime = 0.5f;

    Vector3 m_StandingPosition;
    Vector3 m_CrouchingPosition;

    Vector3 m_CurrentVelocity;


    // Start is called before the first frame update
    void Start()
    {
        m_StandingPosition = transform.localPosition;

        m_CrouchingPosition = transform.localPosition;
        m_CrouchingPosition.y = CrouchHeight;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition;

        if (Input.GetButton("crouch"))
        {
            targetPosition = m_CrouchingPosition;
        }
        else
        {
            targetPosition = m_StandingPosition;
        }


        transform.localPosition = Vector3.SmoothDamp(
            transform.localPosition,
            targetPosition,
            ref m_CurrentVelocity,
            CrouchSmoothTime
            );
    }
}
