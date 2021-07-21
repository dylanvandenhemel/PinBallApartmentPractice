using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform LeftPaddle;
    public Transform RightPaddle;

    Quaternion LeftRotation;
    Quaternion leftStartRotation;
    Quaternion rightRotation;
    Quaternion rightStartRotation;

    public float flickSpeed = 10;
    private float flickOn;
    public float returnSpeed = 5;
    private float flickOff;

    PlayerControls pActions;

    private void Start()
    {
        LeftPaddle.rotation = Quaternion.AngleAxis(-40, Vector3.forward);
        LeftRotation = Quaternion.AngleAxis(20, Vector3.forward);
        leftStartRotation = LeftPaddle.rotation;

        RightPaddle.rotation = Quaternion.AngleAxis(-140, Vector3.forward);
        rightRotation = Quaternion.AngleAxis(-200, Vector3.forward);
        rightStartRotation = RightPaddle.rotation;
    }

    private void OnEnable()
    {
        pActions = new PlayerControls();
        pActions.Enable();
    }

    private void OnDisable()
    {
        pActions.Disable();
    }

    private void Update()
    {
        flickOn = flickSpeed * Time.deltaTime;
        flickOff = returnSpeed * Time.deltaTime;

        if (pActions.PlayerActions.PaddleLeft.ReadValue<float>() != 0)
        {
            LeftPaddle.rotation = Quaternion.RotateTowards(LeftPaddle.rotation, LeftRotation, flickOn);
        }
        else if(pActions.PlayerActions.PaddleLeft.ReadValue<float>() == 0)
        {
            LeftPaddle.rotation = Quaternion.RotateTowards(LeftPaddle.rotation, leftStartRotation, flickOff);
        }

        if (pActions.PlayerActions.PaddleRight.ReadValue<float>() != 0)
        {
            RightPaddle.rotation = Quaternion.RotateTowards(RightPaddle.rotation, rightRotation, flickOn);
        }
        else if(pActions.PlayerActions.PaddleRight.ReadValue<float>() == 0)
        {
            RightPaddle.rotation = Quaternion.RotateTowards(RightPaddle.rotation, rightStartRotation, flickOff);
        }
    }


}
