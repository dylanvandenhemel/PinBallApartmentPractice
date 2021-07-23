using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector3 ballStart;

    private bool flickActive;
    Vector3 flick;
    PlayerControls pActions;

    private void Start()
    {
        ballStart = transform.position;
        flick = new Vector3(0, 200, 0);
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

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("DeadZone"))
        {
            transform.position = ballStart;
        }
        
        if(other.CompareTag("PaddleL"))
        {
            //Make Paddle work only on press not hold
            if (pActions.PlayerActions.PaddleLeft.ReadValue<float>() != 0)
            {
                transform.GetComponent<Rigidbody>().AddForce(flick);
            }

        }
        if (other.CompareTag("PaddleR"))
        {
            //Make Paddle work only on press not hold
            if (pActions.PlayerActions.PaddleRight.ReadValue<float>() != 0)
            {
                transform.GetComponent<Rigidbody>().AddForce(flick);
            }

        }
    }


}
