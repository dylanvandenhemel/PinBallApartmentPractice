using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector3 ballStart;

    private void Start()
    {
        ballStart = transform.position;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("DeadZone"))
        {
            transform.position = ballStart;
        }
        
    }


}
