using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorRaycast : MonoBehaviour
{
   [SeralizeField] Private int rayLength = 5;
   [SeralizeField] Private Layer layerMaskInteract;
   [SeralizeField] Private string excludeLayerName = null;

   private MyDoorController raycastedObj;

   [SeralizeField] private KeyCode opeDoorKey = KeyCode.Mouse0;  

   [SerializeField] private Image crosshair = null;
}
