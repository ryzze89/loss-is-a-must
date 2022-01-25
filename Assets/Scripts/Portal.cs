using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] Portal targetPortal;
    [SerializeField] Transform outPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<CharacterController>().enabled = false;

            other.gameObject.transform.position = targetPortal.outPoint.position;

            other.gameObject.GetComponent<CharacterController>().enabled = true;
        }
    }
}
