using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector3 ballStart;
    Vector3 ballStop;

    private Transform Pad;
    Vector3 bouncePad;
    private bool bbounceTrigger;
    public float tbounceRetract = 1f;
    public float retractSpeed = 10;

    private void Start()
    {
        ballStart = transform.position;
        ballStop = new Vector3(0, 0, 0);
        bouncePad = new Vector3(2, 1, 2);
    }

    private void Update()
    {
        if(bbounceTrigger == true)
        {
            tbounceRetract -= Time.deltaTime * retractSpeed;
            if(tbounceRetract <= 0)
            {
                Pad.transform.localScale = new Vector3(1, 1, 1);
                bbounceTrigger = false;
                tbounceRetract = 1f;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("DeadZone"))
        {
            GetComponent<Rigidbody>().velocity = ballStop;
            transform.position = ballStart;
        }

        if(other.CompareTag("BouncePad"))
        {
            Pad = other.transform;
            Pad.transform.localScale = bouncePad;
            bbounceTrigger = true;
        }
        
    }


}
