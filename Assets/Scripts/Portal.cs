using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] Portal targetPortal;
    [SerializeField] Transform outPoint;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("A");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log(targetPortal.outPoint.position);
            other.gameObject.GetComponent<>
            other.gameObject.transform.position = targetPortal.outPoint.position;

        }
    }
}
