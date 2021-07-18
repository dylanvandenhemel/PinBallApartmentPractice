using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform LeftPaddle;
    public Transform RightPaddle;


    public float flickSpeed = 30;
    public float returnSpeed = 10;

    PlayerControls pActions;

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
        //NOTE: transform.rotation.z is the local rotation found in the debug mode, not the world rotation
        if(pActions.PlayerActions.PaddleLeft.ReadValue<float>() != 0 && LeftPaddle.rotation.z <= 0.3)
        {
            LeftPaddle.Rotate(0, 0, 1 * Time.deltaTime * flickSpeed);

        }
        else if(pActions.PlayerActions.PaddleLeft.ReadValue<float>() == 0 && LeftPaddle.rotation.z >= -0.3)
        {
            LeftPaddle.Rotate(0, 0, -1 * Time.deltaTime * returnSpeed);
        }

        if (pActions.PlayerActions.PaddleRight.ReadValue<float>() != 0 && RightPaddle.rotation.x <= 0.3)
        {
            RightPaddle.Rotate(0, 0, 1 * Time.deltaTime * flickSpeed);

        }
        else if (pActions.PlayerActions.PaddleRight.ReadValue<float>() == 0 && RightPaddle.rotation.x >= -0.3)
        {
            RightPaddle.Rotate(0, 0, -1 * Time.deltaTime * returnSpeed);
        }
    }


}
