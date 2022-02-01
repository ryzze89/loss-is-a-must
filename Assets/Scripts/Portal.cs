using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] string portalID;
    [SerializeField] string targetPortalID;
    Portal targetPortal;
    [SerializeField] Transform outPoint;
    [SerializeField] string portalType;

    void Start()
    {
        GameObject[] portals = GameObject.FindGameObjectsWithTag("Portal");
        if (portalType == "teleporter")
        {
            targetPortal = Array.Find(portals, p => p.GetComponent<Portal>().portalID == targetPortalID).GetComponent<Portal>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && portalType == "teleporter")
        {
            other.gameObject.GetComponent<CharacterController>().enabled = false;

            other.gameObject.transform.position = targetPortal.outPoint.position;

            other.gameObject.GetComponent<CharacterController>().enabled = true;
        }
    }
}
